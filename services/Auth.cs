using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using cryptonance.models;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using cryptonance.state;

namespace cryptonance.services
{
    internal class Auth
    {
        static string connectionString = "Data Source=DESKTOP-60OT1H6\\SQLEXPRESS;Initial Catalog=cryptonance;Integrated Security=True";

        private bool CheckIfUserExist(string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [user] WHERE email = @email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    connection.Close();
                }
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Register(models.User user)
        {
            bool userExist = this.CheckIfUserExist(user.email);
            if (userExist)
            {
                MessageBox.Show("User already exists");
                return false;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [user] (email, password, username, role) OUTPUT INSERTED.id VALUES (@email, @password, @username, @role)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@email", user.email);
                    command.Parameters.AddWithValue("@password", user.password);
                    command.Parameters.AddWithValue("@role", "normal");
                    var userId = command.ExecuteScalar();

                    if (userId != null)
                    {
                        AppState.CurrentUser = new models.User(userId, user.username, user.email, user.password, "normal");
                        AppState.IsUserLoggedIn = true;
                        this.SeedWallet(userId);
                    }
                    connection.Close();

                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void SeedWallet(object id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [wallets] (userId, btc, ltc, eth) VALUES (@userId, @btc, @ltc, @eth)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", id);
                    command.Parameters.AddWithValue("@btc", 0);
                    command.Parameters.AddWithValue("@ltc", 0);
                    command.Parameters.AddWithValue("@eth", 0);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Login(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [user] WHERE email = @email AND password = @password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            AppState.CurrentUser = new models.User(reader["id"], reader["username"].ToString(), reader["email"].ToString(), reader["password"].ToString(), reader["role"].ToString());
                            AppState.IsUserLoggedIn = true;
                        }
                        return true;
                    }

                    connection.Close();
                }
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
