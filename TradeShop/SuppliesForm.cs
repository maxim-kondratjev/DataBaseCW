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
    public partial class SuppliesForm : Form
    {
        public SuppliesForm()
        {
            InitializeComponent();
        }

        public SuppliesForm(bool admition)
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
            товары_в_поставкахDataGridView.ReadOnly = true;
            товары_в_поставкахDataGridView.AllowUserToAddRows = false;
            товары_в_поставкахDataGridView.AllowUserToDeleteRows = false;
        }

        private void SuppliesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.товарооборот_магазинаDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.товарооборот_магазинаDataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.товарооборот_магазинаDataSet.Склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Товары_в_поставках". При необходимости она может быть перемещена или удалена.
            this.товары_в_поставкахTableAdapter.Fill(this.товарооборот_магазинаDataSet.Товары_в_поставках);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Поставка". При необходимости она может быть перемещена или удалена.
            this.поставкаTableAdapter.Fill(this.товарооборот_магазинаDataSet.Поставка);
            this.акцияDataGridView.DataError += new DataGridViewDataErrorEventHandler(акцияDataGridView_DataError);
            this.товары_в_поставкахDataGridView.DataError += new DataGridViewDataErrorEventHandler(товары_в_поставкахDataGridView_DataError);
        }

        private void акцияDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Проверте правильность введенных данных");
        }

        private void товары_в_поставкахDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Проверте правильность введенных данных");
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sup_StockTableAdapter.Fill(this.товарооборот_магазинаDataSet.Sup_Stock, Stock.Text);
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
                this.suppliesInTimeTableAdapter.Fill(this.товарооборот_магазинаDataSet.SuppliesInTime, Date1.Value.Date, Date2.Value.Date);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Delete2_Click(object sender, EventArgs e)
        {
            DataGridViewRow buf;
            int delet;
            try
            {
                delet = товары_в_поставкахDataGridView.SelectedCells[0].RowIndex;
                buf = товары_в_поставкахDataGridView.Rows[delet];
                товары_в_поставкахDataGridView.Rows.RemoveAt(delet);
                Update2_Click(sender, e);
            }
            catch
            {
                товары_в_поставкахTableAdapter.Fill(товарооборот_магазинаDataSet.Товары_в_поставках);
                MessageBox.Show("Ошибка при удалении");
            }
            товары_в_поставкахTableAdapter.Fill(товарооборот_магазинаDataSet.Товары_в_поставках);
        }

        private void Update1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.поставкаBindingSource.EndEdit();
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

        private void Update2_Click(object sender, EventArgs e)
        {
            try
            {
                Update1_Click(sender, e);
                this.Validate();
                this.товары_в_поставкахBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.товарооборот_магазинаDataSet);
            }
            catch/*(SqlException exs)*/
            {
                try
                {
                    throw;
                }
                catch
                {
                    MessageBox.Show("Ошибка");
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
                поставкаTableAdapter.Fill(товарооборот_магазинаDataSet.Поставка);
                MessageBox.Show("Ошибка при удалении");
            }
            поставкаTableAdapter.Fill(товарооборот_магазинаDataSet.Поставка);
        }
    }
}
