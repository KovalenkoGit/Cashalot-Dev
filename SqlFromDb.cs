using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashalot_Dev
{
    internal class SqlFromDb
    {
        private SqlConnection sqlConnection;

        public SqlFromDb(SqlConnection connection)
        {
            sqlConnection = connection;
        }

        public void InsertAddress(string address, int groupId)
        {
            string query = "INSERT INTO [Address] (Address, GroupId) VALUES (@Address, @GroupId)";
            int rowsAdd;
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@GroupId", groupId);
                rowsAdd = command.ExecuteNonQuery();
            }
            MessageBox.Show("Додано записів "+rowsAdd.ToString());
        }

        public DataTable SelectFromTable(string newSelect)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(newSelect, sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}
