using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using cryptonance.state;

namespace cryptonance.services
{
    internal class Profile
    {
        static string connectionString = "Data Source=DESKTOP-60OT1H6\\SQLEXPRESS;Initial Catalog=cryptonance;Integrated Security=True";

        public void UpdateProfile(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE [user] SET username = @username, password = @password WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@id", AppState.CurrentUser.id);
                    command.ExecuteNonQuery();
                    connection.Close();

                    AppState.CurrentUser.UpdateUsername(username);
                    AppState.CurrentUser.UpdatePassword(password);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
