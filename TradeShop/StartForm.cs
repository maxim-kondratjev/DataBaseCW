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
    public partial class StartForm : Form
    {
        Table SQL_Users = new Table("SELECT * FROM dbo.Пользователи");
        List<Pair<String, String>> LogData = new List<Pair<String, String>>();

        public StartForm()
        {
            InitializeComponent();
            for (int i = 0; i < SQL_Users.SQL_Table.Select().Length; i++)
            {
                LogData.Add(new Pair<String, String>(SQL_Users.SQL_Table.Select()[i].ItemArray[0].ToString().Trim(), SQL_Users.SQL_Table.Select()[i].ItemArray[1].ToString().Trim()));
            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарооборот_магазинаDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.товарооборот_магазинаDataSet.Пользователи);
            login.SelectedIndex = -1;
        }
        /*      */
        private void Login_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < login.Items.Count; i++)
            {
                if ((((DataRowView)login.SelectedItem).Row.ItemArray[0].ToString()== LogData[i].First) && (password.Text == LogData[i].Second))
                {
                    MainMenu Form = new MainMenu(LogData[i].First, SQL_Users.SQL_Table);
                    this.Hide();
                    Form.Show(this);
                    Form.Focus();
                    password.ResetText();
                    return;
                }
            }
            MessageBox.Show("Неверный логин/пароль");
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
    }
}
