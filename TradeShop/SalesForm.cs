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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        public SalesForm(bool admition)
        {
            InitializeComponent();
            if (!admition)
                Close_Adm();
        }

        private void Close_Adm()
        {
            Update1.Hide();
            Delete1.Hide();
            акцияDataGridView.ReadOnly = true;
            акцияDataGridView.AllowUserToAddRows = false;
            акцияDataGridView.AllowUserToDeleteRows = false;
            Update2.Hide();
            Delete2.Hide();
            продажи_товаровDataGridView.ReadOnly = true;
            продажи_товаровDataGridView.AllowUserToAddRows = false;
            продажи_товаровDataGridView.AllowUserToDeleteRows = false;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Seller". При необходимости она может быть перемещена или удалена.
            this.sellerTableAdapter.Fill(this.товарооборот_магазинаDataSet.Seller);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.товарооборот_магазинаDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Работник". При необходимости она может быть перемещена или удалена.
            this.работникTableAdapter.Fill(this.товарооборот_магазинаDataSet.Работник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Продажи_товаров". При необходимости она может быть перемещена или удалена.
            this.продажи_товаровTableAdapter.Fill(this.товарооборот_магазинаDataSet.Продажи_товаров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Продажа". При необходимости она может быть перемещена или удалена.
            this.продажаTableAdapter.Fill(this.товарооборот_магазинаDataSet.Продажа);

            this.акцияDataGridView.DataError += new DataGridViewDataErrorEventHandler(акцияDataGridView_DataError);
            this.продажи_товаровDataGridView.DataError += new DataGridViewDataErrorEventHandler(продажи_товаровDataGridView_DataError);

        }

        private void акцияDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Проверте правильность введенных данных");
        }

        private void продажи_товаровDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Проверте правильность введенных данных");
        }

        private void Delete2_Click(object sender, EventArgs e)
        {

            DataGridViewRow buf;
            int delet;
            try
            {
                delet = продажи_товаровDataGridView.SelectedCells[0].RowIndex;
                buf = продажи_товаровDataGridView.Rows[delet];
                продажи_товаровDataGridView.Rows.RemoveAt(delet);
                Update2_Click(sender, e);
            }
            catch
            {
                продажи_товаровTableAdapter.Fill(товарооборот_магазинаDataSet.Продажи_товаров);
                MessageBox.Show("Ошибка при удалении");
            }
            продажи_товаровTableAdapter.Fill(товарооборот_магазинаDataSet.Продажи_товаров);
        }

        private void Update2_Click(object sender, EventArgs e)
        {
            try
            {
                Update1_Click(sender, e);
                this.Validate();
                this.продажи_товаровBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.товарооборот_магазинаDataSet);
            }
            catch/*(SqlException exs)*/
            {
                //MessageBox.Show(exs.Message);
                try
                {
                    throw;
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        private void Update1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.продажаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.товарооборот_магазинаDataSet);
            }
            catch/*(SqlException exs)*/
            {
                //MessageBox.Show(exs.Message);
                try
                {
                    throw;
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        private void Delete1_Click(object sender, EventArgs e)
        {
            DataGridViewRow buf;
            int delet;
            try
            {
                delet = акцияDataGridView.SelectedCells[0].RowIndex;
                buf = акцияDataGridView.Rows[delet];
                акцияDataGridView.Rows.RemoveAt(delet);
                Update1_Click(sender, e);
            }
            catch
            {
                продажаTableAdapter.Fill(товарооборот_магазинаDataSet.Продажа);
                MessageBox.Show("Ошибка при удалении");
            }
            продажаTableAdapter.Fill(товарооборот_магазинаDataSet.Продажа);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sales_ItemTableAdapter.Fill(this.товарооборот_магазинаDataSet.Sales_Item, Item.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.date_SalesTableAdapter.Fill(this.товарооборот_магазинаDataSet.Date_Sales, Date.Value.Date);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
