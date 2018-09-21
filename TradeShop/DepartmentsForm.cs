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
    public partial class DepartmentsForm : Form
    {
        public DepartmentsForm()
        {
            InitializeComponent();
        }

        public DepartmentsForm(bool admition)
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
            наименование_отделаTextBox.ReadOnly = true;
            расположение_отделаTextBox.ReadOnly = true;
            Наименование.Hide();
            Расположение.Hide();
            label1.Hide();
            label2.Hide();
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet1.Акция". При необходимости она может быть перемещена или удалена.
            this.акцияTableAdapter.Fill(this.товарооборот_магазинаDataSet.Акция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Отдел". При необходимости она может быть перемещена или удалена.
            this.отделTableAdapter.Fill(this.товарооборот_магазинаDataSet.Отдел);
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

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Utility.GetConnectionString());
            try
            {
                connection.Open();
                String que = "INSERT INTO dbo.Отдел ([Наименование отдела], [Расположение отдела]) Values('" + Наименование.Text + "','" + Расположение.Text + "')";
                SqlCommand cmd = new SqlCommand(que, connection);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись успешно добавлена.");
                connection.Close();
                Update_Click(sender, e);
                Наименование.ResetText();
                Расположение.ResetText();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении");
            }
            отделTableAdapter.Fill(товарооборот_магазинаDataSet.Отдел);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.отделBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.товарооборот_магазинаDataSet);
            }
            catch
            {
                throw;
            }
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
                отделTableAdapter.Fill(товарооборот_магазинаDataSet.Отдел);
                MessageBox.Show("Ошибка при удалении");
            }
            отделTableAdapter.Fill(товарооборот_магазинаDataSet.Отдел);
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.dep_ItemTableAdapter.Fill(this.товарооборот_магазинаDataSet.Dep_Item, dep.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
