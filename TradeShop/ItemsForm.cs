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
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }

        public ItemsForm(bool admition)
        {
            InitializeComponent();
            if (!admition)
                Close_Adm();           
        }

        private void Close_Adm()
        {
            Update.Hide();
            Delete.Hide();
            акцияDataGridView.ReadOnly = true;
            акцияDataGridView.AllowUserToAddRows = false;
            акцияDataGridView.AllowUserToDeleteRows = false;
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Акционные_товары". При необходимости она может быть перемещена или удалена.
            this.акционные_товарыTableAdapter.Fill(this.товарооборот_магазинаDataSet.Акционные_товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Акция". При необходимости она может быть перемещена или удалена.
            this.акцияTableAdapter.Fill(this.товарооборот_магазинаDataSet.Акция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Отдел". При необходимости она может быть перемещена или удалена.
            this.отделTableAdapter.Fill(this.товарооборот_магазинаDataSet.Отдел);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.товарооборот_магазинаDataSet.Товар);
            this.акцияDataGridView.DataError += new DataGridViewDataErrorEventHandler(акцияDataGridView_DataError);
        }

        private void акцияDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Проверте правильность введенных данных");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.акцияBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.товарооборот_магазинаDataSet);
            }
            catch/*(SqlException exs)*/
            {
                throw;
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prom_ItemTableAdapter.Fill(this.товарооборот_магазинаDataSet.Prom_Item, Prom.Text);
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
                this.itemsInPriceTableAdapter.Fill(this.товарооборот_магазинаDataSet.ItemsInPrice, new System.Nullable<long>(((long)(System.Convert.ChangeType(priceToolStripTextBox.Text, typeof(long))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Необходимо числовое значение");
            }

        }
    }
}
