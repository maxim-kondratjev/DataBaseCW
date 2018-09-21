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
    public partial class PromotionsForm : Form
    {
        public PromotionsForm()
        {
            InitializeComponent();
        }
        public PromotionsForm(bool admition)
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
            типTextBox.ReadOnly = true;
            дата_начала_акцииDateTimePicker.Enabled = false;
            дата_конца_акцииDateTimePicker.Enabled = false;
            Тип.Hide();
            Дата_начала.Hide();
            Дата_конца.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
        }

        private void PromotionsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Текущие_акции". При необходимости она может быть перемещена или удалена.
            this.текущие_акцииTableAdapter.Fill(this.товарооборот_магазинаDataSet.Текущие_акции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Акция". При необходимости она может быть перемещена или удалена.
            this.акцияTableAdapter.Fill(this.товарооборот_магазинаDataSet.Акция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Акция". При необходимости она может быть перемещена или удалена.
            this.акцияTableAdapter.Fill(this.товарооборот_магазинаDataSet.Акция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Акция". При необходимости она может быть перемещена или удалена.
            this.акцияTableAdapter.Fill(this.товарооборот_магазинаDataSet.Акция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Акция". При необходимости она может быть перемещена или удалена.
            this.акцияTableAdapter.Fill(this.товарооборот_магазинаDataSet.Акция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Акция". При необходимости она может быть перемещена или удалена.
            this.акцияTableAdapter.Fill(this.товарооборот_магазинаDataSet.Акция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Акция". При необходимости она может быть перемещена или удалена.
            this.акцияTableAdapter.Fill(this.товарооборот_магазинаDataSet.Акция);
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
                String que = "INSERT INTO dbo.Акция (Тип, [Дата начала акции], [Дата конца акции]) Values('" + Тип.Text + "','" + Дата_начала.Value.ToShortDateString() + "','" + Дата_конца.Value.ToShortDateString() + "')";

                SqlCommand cmd = new SqlCommand(que, connection);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись успешно добавлена.");
                connection.Close();
                Update_Click(sender, e);
                Тип.ResetText();
                Дата_начала.ResetText();
                Дата_конца.ResetText();
            }
            catch 
            {
                MessageBox.Show("Ошибка при добавлении");
            }
            акцияTableAdapter.Fill(товарооборот_магазинаDataSet.Акция);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.акцияBindingSource.EndEdit();
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
                акцияTableAdapter.Fill(товарооборот_магазинаDataSet.Акция);
                MessageBox.Show("Ошибка при удалении");
            }
            акцияTableAdapter.Fill(товарооборот_магазинаDataSet.Акция);
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
    }
}
