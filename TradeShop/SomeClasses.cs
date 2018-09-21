using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TradeShop
{
    public partial class Pair<T, K>
    {
        public Pair()
        {
        }
        public Pair(T _First, K _Second)
        {
            this.First = _First;
            this.Second = _Second;
        }
        public T First { get; set; }
        public K Second { get; set; }
    }

    internal class Utility
    {
        internal static string GetConnectionString()
        {
            String str = "Data Source=RACKISCHE\\SQLEXPRESS;Initial Catalog=\"Товарооборот магазина\";Integrated Security=True";
            return str;
        }
    }

    public partial class Table
    {
        public DataTable SQL_Table = new DataTable();
        String sql;
        public Table(String _sql)
        {
            this.sql = _sql;
            Read_Table_From_SQL();
        }
        private void Read_Table_From_SQL()
        {
            SqlConnection conn = new SqlConnection("Data Source=RACKISCHE\\SQLEXPRESS;Initial Catalog=\"Товарооборот магазина\";Integrated Security=True");
            
            try
            {            
                conn.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                SQL_Table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(SQL_Table);
                
            }
            catch
            {
                MessageBox.Show("The requested order could not be loaded into the form.");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
