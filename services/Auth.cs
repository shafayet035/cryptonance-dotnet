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
            if(userExist)
            {
                MessageBox.Show("User already exist");
                return false;
            }
            Console.WriteLine("Is it working?");
            try {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [user] (email, password, username) VALUES (@email, @password, @username)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@email", user.email);
                    command.Parameters.AddWithValue("@password", user.password);
                    command.ExecuteNonQuery();
                    connection.Close();

                    return true;
                }
            } catch (Exception e) {
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
                            AppState.CurrentUser = new models.User(reader["id"], reader["username"].ToString(), reader["email"].ToString(), reader["password"].ToString());
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
