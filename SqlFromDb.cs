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

        public void InsertAddress(string address, int? groupId)
        {
            string query = "INSERT INTO [Address] (Address, GroupId) VALUES (@Address, @GroupId)";
            int rowsAdd;
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@GroupId", groupId.HasValue ? (object)groupId.Value : DBNull.Value);

                rowsAdd = command.ExecuteNonQuery();
            }
            MessageBox.Show("Додано записів "+rowsAdd.ToString());
        }

        public void UpdateAddress(string id, string address, int? groupId)
        {
            string query = "UPDATE [Address] SET Address = @Address, GroupId = @GroupId WHERE Id = @Id";

            try
            {
                if (int.TryParse(id, out int parsedId))
                { 
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Id", parsedId);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@GroupId", groupId.HasValue ? (object)groupId.Value : DBNull.Value);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Запис оновлено");
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні запису: {ex.Message}");
            }
        }

        public DataTable SelectFromTable(string newSelect)
        {
            try
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(newSelect, sqlConnection))
                {
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при виконанні запиту: {ex.Message}");
            }
        }
    }
}
