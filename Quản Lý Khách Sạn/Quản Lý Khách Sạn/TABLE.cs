using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Quản_Lý_Khách_Sạn
{
    public partial class TABLE
    {
        private OleDbConnection cn = new OleDbConnection();
        private string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= QuanLyKhachSan.mdb";
        public DataTable Read(string query)
        {
            DataTable t = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
            dataAdapter.Fill(t);
            return t;
        }
        public void Write(DataTable Table, string database_Table)
        {
            string query = "select * from " + database_Table;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
            dynamic cb = new OleDbCommandBuilder(dataAdapter);
            cb.QuotePrefix = "[";
            cb.QuoteSuffix = "]";
            dataAdapter.Update(Table);
        }
        public void cbb_DataLoad(ComboBox cbb, string table, string valueMember, string displayMember, string condition = "", bool addEmptyRow = false)
        {
            string query = "SELECT " + valueMember + "," + displayMember + " FROM " + table + " " + condition;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            if (addEmptyRow == true)
            {
                DataRow emptyRow = ds.Tables[0].NewRow();
                emptyRow[0] = "";
                emptyRow[1] = "";
                ds.Tables[0].Rows.Add(emptyRow);
            }

            cbb.DataSource = ds.Tables[0];
            cbb.ValueMember = ds.Tables[0].Columns[0].ColumnName;
            cbb.DisplayMember = ds.Tables[0].Columns[1].ColumnName;
        }
        //public object dataGet(string table, string column, string condition)
        //{
        //    string query = "SELECT " + column + " AS result FROM " + table + " " + condition;
        //    object result = null;
        //    OleDbCommand cmd = new OleDbCommand();
        //    cn.ConnectionString = connection;
        //    cn.Open();
        //    cmd.CommandText = query;
        //    cmd.Connection = cn;
        //    OleDbDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        result = reader["result"];
        //    }
        //    cn.Close();
        //    return result;
        //}
    }
}
