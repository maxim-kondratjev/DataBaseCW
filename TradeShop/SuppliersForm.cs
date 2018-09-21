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
    public partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();
        }

        public SuppliersForm(bool admition)
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
            адресTextBox.ReadOnly = true;
            названиеTextBox.ReadOnly = true;
            Адрес.Hide();
            Название.Hide();
            label1.Hide();
            label2.Hide();
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.товарооборот_магазинаDataSet.Поставщик);
            this.акцияDataGridView.DataError += new DataGridViewDataErrorEventHandler(акцияDataGridView_DataError);
        }

        private void акцияDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Проверте правильность введенных данных");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Utility.GetConnectionString());
            try
            {
                connection.Open();
                String que = "INSERT INTO dbo.Поставщик (Название, Адрес) Values('" + Название.Text + "','" + Адрес.Text + "')";

                SqlCommand cmd = new SqlCommand(que, connection);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись успешно добавлена.");
                connection.Close();
                Update_Click(sender, e);
                Название.ResetText();
                Адрес.ResetText();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении");
            }
            поставщикTableAdapter.Fill(товарооборот_магазинаDataSet.Поставщик);
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
                this.поставщикBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.товарооборот_магазинаDataSet);
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
                поставщикTableAdapter.Fill(товарооборот_магазинаDataSet.Поставщик);
                MessageBox.Show("Ошибка при удалении");
            }
            поставщикTableAdapter.Fill(товарооборот_магазинаDataSet.Поставщик);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sup_SupTableAdapter.Fill(this.товарооборот_магазинаDataSet.Sup_Sup, Suplier.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
