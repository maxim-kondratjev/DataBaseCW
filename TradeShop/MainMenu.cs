using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeShop
{
    public partial class MainMenu : Form
    {
        public String CurrentUser;
        public DataTable Users = new DataTable();
        public PromotionsForm PF;
        public DepartmentsForm DF;
        public ItemsForm IF;
        public SalesForm SalF;
        public StaffForm SF;
        public StocksForm StF;
        public SuppliersForm SrsF;
        public SuppliesForm SsF;

        public MainMenu()
        {
            InitializeComponent();
        }
        public MainMenu(String User, DataTable _Users)
        {
            InitializeComponent();
            Cur_User.Text = User;
            CurrentUser = User;
            this.Users = _Users;
        }
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }


        public bool Admition_For_Data(String TableName)
        {
            bool adm = false;
            foreach (System.Data.DataRow row in Users.Select())
            {
                if (row.ItemArray[0].ToString().Trim() == CurrentUser)
                {
                    int i = 0;
                    foreach (DataColumn col in row.Table.Columns)
                    {
                        if (col.ToString().Trim() == TableName)
                        {
                            if (row.ItemArray[i].Equals(1))
                            {
                                adm = true;
                                return adm;
                            }
                        }
                        i++;
                    }
                }
            }
            return adm;
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Other_Log_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (PF != null)
                PF.Close();
            if (DF != null)
                DF.Close();
            if (IF != null)
                IF.Close();
            if (SalF != null)
                SalF.Close();
            if (SF != null)
                SF.Close();
            if (StF != null)
                StF.Close();
            if (SrsF != null)
                SrsF.Close();
            if (SsF != null)
                SsF.Close();

            this.Owner.Show();
            this.Owner.Focus();           
        }

        private void Promotions_Click(object sender, EventArgs e)
        {
            if (PF != null)
                PF.Close();         
            PF = new PromotionsForm(Admition_For_Data("Promotions"));
            PF.Show();
            PF.Focus();
        }

        private void Items_Click(object sender, EventArgs e)
        {
            if (IF != null)
                IF.Close();
            IF = new ItemsForm(Admition_For_Data("Items"));
            IF.Show();
            IF.Focus();
        }

        private void Stocks_Click(object sender, EventArgs e)
        {
            if (StF != null)
                StF.Close();
            StF = new StocksForm(Admition_For_Data("Stocks"));
            StF.Show();
            StF.Focus();
        }

        private void Departments_Click(object sender, EventArgs e)
        {
            if (DF != null)
                DF.Close();
            DF = new DepartmentsForm(Admition_For_Data("Departments"));
            DF.Show();
            DF.Focus();
        }

        private void Supplies_Click(object sender, EventArgs e)
        {
            if (SsF != null)
                SsF.Close();
            SsF = new SuppliesForm(Admition_For_Data("Supplies"));
            SsF.Show();
            SsF.Focus();
        }

        private void Supliers_Click(object sender, EventArgs e)
        {
            if (SrsF != null)
                SrsF.Close();
            SrsF = new SuppliersForm(Admition_For_Data("Supliers"));
            SrsF.Show();
            SrsF.Focus();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            if (SF != null)
                SF.Close();
            SF = new StaffForm(Admition_For_Data("Personal"));
            SF.Show();
            SF.Focus();
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            if (SalF != null)
                SalF.Close();
            SalF = new SalesForm(Admition_For_Data("Sales"));
            SalF.Show();
            SalF.Focus();
        }
    }
}
