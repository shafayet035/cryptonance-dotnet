using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using cryptonance.state;

namespace cryptonance.services
{
    internal class Wallet
    {
        static string connectionString = "Data Source=DESKTOP-60OT1H6\\SQLEXPRESS;Initial Catalog=cryptonance;Integrated Security=True";

        public void GetWalletBalance()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [wallets] WHERE userId = @user_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@user_id", AppState.CurrentUser.id);
                    SqlDataReader reader = command.ExecuteReader();
                    
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            models.Wallet newWall = new models.Wallet(
                                 reader["id"],
                                Convert.ToSingle(reader["btc"]),
                                Convert.ToSingle(reader["ltc"]),
                                Convert.ToSingle(reader["eth"])
                            );

                            AppState.Wallet = newWall;
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

        public void GetCryptos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [currency]";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    AppState.Cryptos.Clear();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            models.Crypto crypto = new models.Crypto(
                                reader["id"],
                                reader["name"].ToString(),
                                reader["tag"].ToString(),
                                Convert.ToSingle(reader["price"]),
                                Convert.ToSingle(reader["selling_rate"])
                            );
                            AppState.Cryptos.Add(crypto);
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
