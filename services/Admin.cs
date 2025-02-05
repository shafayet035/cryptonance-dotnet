using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cryptonance.state;


namespace cryptonance.services
{
    internal class Admin
    {
        public string connectionString = AppState.connectionString;

        public void UpdateCryptoPrices(int id, float buyPrice, float sellPrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE currency SET price = @buyPrice, selling_rate = @sellPrice WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@buyPrice", buyPrice);
                        command.Parameters.AddWithValue("@sellPrice", sellPrice);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();

                        connection.Close();

                        AppState.Cryptos.Find(c => Convert.ToInt32(c.id) == id).price = buyPrice;
                        AppState.Cryptos.Find(c => Convert.ToInt32(c.id) == id).sellingRate = sellPrice;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void GetAllUsers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [user]";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            AppState.Users.Clear();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    models.User newUser = new models.User(
                                        reader["id"],
                                        reader["username"].ToString(),
                                        reader["email"].ToString(),
                                        reader["password"].ToString(),
                                        reader["role"] != DBNull.Value ? reader["role"].ToString() : string.Empty
                                    );
                                    AppState.Users.Add(newUser);
                                }
                            }
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

        public void UpdateUser(int id, string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE [user] SET username = @username, password = @password WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        connection.Close();
                        AppState.CurrentUser.username = username;
                        AppState.CurrentUser.password = password;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM [user] WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        connection.Close();
                        AppState.Users.RemoveAll(u => Convert.ToInt32(u.id) == id);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
