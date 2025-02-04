using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using cryptonance.state;

namespace cryptonance.services
{
    internal class Transfer
    {
        static string connectionString = "Data Source=DESKTOP-60OT1H6\\SQLEXPRESS;Initial Catalog=cryptonance;Integrated Security=True";

        public void SendCrypto(models.Crypto crypto, float cryptoAmount, string receiverEmail)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Get receiver id
                            string getReceiverIdQuery = "SELECT id FROM [user] WHERE email = @email";
                            SqlCommand getReceiverIdCommand = new SqlCommand(getReceiverIdQuery, connection, transaction);
                            getReceiverIdCommand.Parameters.AddWithValue("@email", receiverEmail);
                            SqlDataReader reader = getReceiverIdCommand.ExecuteReader();

                            if (reader.HasRows)
                            {
                                reader.Read();
                                int receiverId = Convert.ToInt32(reader["id"]);
                                reader.Close();

                                string updateSenderWalletQuery = $"UPDATE [wallets] SET {crypto.tag} = {crypto.tag} - @amount WHERE userId = @user_id";
                                SqlCommand updateSenderWalletCommand = new SqlCommand(updateSenderWalletQuery, connection, transaction);
                                updateSenderWalletCommand.Parameters.AddWithValue("@user_id", AppState.CurrentUser.id);
                                updateSenderWalletCommand.Parameters.AddWithValue("@amount", cryptoAmount);
                                updateSenderWalletCommand.ExecuteNonQuery();

                                string updateReceiverWalletQuery = $"UPDATE [wallets] SET {crypto.tag} = {crypto.tag} + @amount WHERE userId = @user_id";
                                SqlCommand updateReceiverWalletCommand = new SqlCommand(updateReceiverWalletQuery, connection, transaction);
                                updateReceiverWalletCommand.Parameters.AddWithValue("@user_id", receiverId);
                                updateReceiverWalletCommand.Parameters.AddWithValue("@amount", cryptoAmount);
                                updateReceiverWalletCommand.ExecuteNonQuery();

                                string insertTransactionQuery = "INSERT INTO [transactions] (userId, type, receiverEmail, cryptoName, cryptoAmount) VALUES (@userId, @type, @email, @cryptoName, @amount)";
                                SqlCommand insertTransactionCommand = new SqlCommand(insertTransactionQuery, connection, transaction);
                                insertTransactionCommand.Parameters.AddWithValue("@userId", AppState.CurrentUser.id);
                                insertTransactionCommand.Parameters.AddWithValue("@cryptoName", crypto.name);
                                insertTransactionCommand.Parameters.AddWithValue("@amount", cryptoAmount);
                                insertTransactionCommand.Parameters.AddWithValue("@type", "Send");
                                insertTransactionCommand.Parameters.AddWithValue("@email", receiverEmail);
                                insertTransactionCommand.ExecuteNonQuery();
                                transaction.Commit();

                                AppState.Wallet.removeAmount(cryptoAmount, crypto.tag);
                            }
                            else
                            {
                                throw new Exception("Receiver not found");
                            }
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
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
