using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TradeShop
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        public StaffForm(bool admition)
        {
            InitializeComponent();
            if (!admition)
                Close_Adm();
        }

        private void Close_Adm()
        {
            Update.Hide();
            Delete.Hide();
            Add.Hide();
            Change.Hide();
            фИОTextBox.ReadOnly = true;
            телефонTextBox.ReadOnly = true;
            адресTextBox.ReadOnly = true; 
            должностьTextBox.ReadOnly = true;
            Имя.Hide();
            Телефон.Hide();
            Адрес.Hide();
            Должность.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.func". При необходимости она может быть перемещена или удалена.
            this.funcTableAdapter.Fill(this.товарооборот_магазинаDataSet.func);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.proceeds". При необходимости она может быть перемещена или удалена.
            this.proceedsTableAdapter.Fill(this.товарооборот_магазинаDataSet.proceeds);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Seller". При необходимости она может быть перемещена или удалена.
            this.sellerTableAdapter.Fill(this.товарооборот_магазинаDataSet.Seller);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Работник". При необходимости она может быть перемещена или удалена.
            this.работникTableAdapter.Fill(this.товарооборот_магазинаDataSet.Работник);
            this.акцияDataGridView.DataError += new DataGridViewDataErrorEventHandler(акцияDataGridView_DataError);
        }

        private void акцияDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Проверте правильность введенных данных");
        }


        private void Change_Click(object sender, EventArgs e)
        {
            try
            {
                Update_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.работникBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.товарооборот_магазинаDataSet);
            }
            catch
            {
                throw;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Utility.GetConnectionString());
            try
            {
                connection.Open();
                String que = "INSERT INTO dbo.Работник (ФИО, [Телефон], [Адрес], Должность) Values('" + Имя.Text + "','" + Телефон.Text + "','" + Адрес.Text + "','" + Должность.Text + "')";

                SqlCommand cmd = new SqlCommand(que, connection);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись успешно добавлена.");
                connection.Close();
                Update_Click(sender, e);
                Имя.ResetText();
                Телефон.ResetText();
                Адрес.ResetText();
                Должность.ResetText();

            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении");
            }
            работникTableAdapter.Fill(товарооборот_магазинаDataSet.Работник);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow buf;
            int delet;
            try
            {
                delet = акцияDataGridView.SelectedCells[0].RowIndex;
                buf = акцияDataGridView.Rows[delet];
                акцияDataGridView.Rows.RemoveAt(delet);
                Update_Click(sender, e);
            }
            catch
            {
                работникTableAdapter.Fill(товарооборот_магазинаDataSet.Работник);
                MessageBox.Show("Ошибка при удалении");
            }
            работникTableAdapter.Fill(товарооборот_магазинаDataSet.Работник);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.worker_FuncTableAdapter.Fill(this.товарооборот_магазинаDataSet.Worker_Func, Func.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
