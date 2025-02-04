using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using cryptonance.state;

namespace cryptonance.services
{
    internal class Transactions
    {
        static string connectionString = "Data Source=DESKTOP-60OT1H6\\SQLEXPRESS;Initial Catalog=cryptonance;Integrated Security=True";


        public void GetAllTransaction()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [transactions] WHERE userId = @user_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@user_id", AppState.CurrentUser.id);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            models.Transaction newTransaction = new models.Transaction(
                                reader["id"] != DBNull.Value ? reader["id"].ToString() : string.Empty,
                                reader["type"] != DBNull.Value ? reader["type"].ToString() : string.Empty,
                                reader["receiverEmail"] != DBNull.Value ? reader["receiverEmail"].ToString() : string.Empty,
                                reader["totalPrice"] != DBNull.Value ? Convert.ToSingle(reader["totalPrice"]) : 0,
                                reader["cryptoAmount"] != DBNull.Value ? Convert.ToSingle(reader["cryptoAmount"]) : 0,
                                reader["cryptoName"] != DBNull.Value ? reader["cryptoName"].ToString() : string.Empty
                            );
                            AppState.Transactions.Add(newTransaction);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
