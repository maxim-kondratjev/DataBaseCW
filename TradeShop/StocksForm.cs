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
    public partial class StocksForm : Form
    {
        public StocksForm()
        {
            InitializeComponent();
        }

        public StocksForm(bool admition)
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
            вместимостьTextBox.ReadOnly = true;
            Адрес.Hide();
            Вместимость.Hide();
            label1.Hide();
            label2.Hide();
            button1.Hide();
            button2.Hide();
            товары_на_складахDataGridView.ReadOnly = true;
            товары_на_складахDataGridView.AllowUserToAddRows = false;
            товары_на_складахDataGridView.AllowUserToDeleteRows = false;
        }

        private void StocksForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.товарооборот_магазинаDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Stocks_occupation". При необходимости она может быть перемещена или удалена.
            this.stocks_occupationTableAdapter.Fill(this.товарооборот_магазинаDataSet.Stocks_occupation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Товары_на_складах". При необходимости она может быть перемещена или удалена.
            this.товары_на_складахTableAdapter.Fill(this.товарооборот_магазинаDataSet.Товары_на_складах);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.товарооборот_магазинаDataSet.Склад);
            this.акцияDataGridView.DataError += new DataGridViewDataErrorEventHandler(акцияDataGridView_DataError);
            this.товары_на_складахDataGridView.DataError += new DataGridViewDataErrorEventHandler(товары_на_складахDataGridView_DataError);
        }

        private void акцияDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Проверте правильность введенных данных");
        }

        private void товары_на_складахDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Проверте правильность введенных данных");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Utility.GetConnectionString());
            try
            {
                connection.Open();
                String que = "INSERT INTO dbo.Склад (Адрес, Вместимость) Values('" + Адрес.Text + "'," + Вместимость.Text + ")";
                SqlCommand cmd = new SqlCommand(que, connection);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись успешно добавлена.");
                connection.Close();
                Update_Click(sender, e);
                Адрес.ResetText();
                Вместимость.ResetText();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении");
            }
            складTableAdapter.Fill(товарооборот_магазинаDataSet.Склад);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.складBindingSource.EndEdit();
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
                складTableAdapter.Fill(товарооборот_магазинаDataSet.Склад);
                MessageBox.Show("Ошибка при удалении");
            }
            складTableAdapter.Fill(товарооборот_магазинаDataSet.Склад);
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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.stock_ItemsTableAdapter.Fill(this.товарооборот_магазинаDataSet.Stock_Items, Stock.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow buf;
            int delet;
            try
            {
                delet =товары_на_складахDataGridView.SelectedCells[0].RowIndex;
                buf = товары_на_складахDataGridView.Rows[delet];
                товары_на_складахDataGridView.Rows.RemoveAt(delet);
                button2_Click(sender, e);
            }
            catch
            {
                товары_на_складахTableAdapter.Fill(товарооборот_магазинаDataSet.Товары_на_складах);
                MessageBox.Show("Ошибка при удалении");
            }
            товары_на_складахTableAdapter.Fill(товарооборот_магазинаDataSet.Товары_на_складах);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.fKТоварыНаСкладахСкладBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.товарооборот_магазинаDataSet);
            }
            catch
            {
                throw;
            }
        }
    }
}
