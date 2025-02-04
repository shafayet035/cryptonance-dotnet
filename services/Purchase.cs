using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using cryptonance.state;

namespace cryptonance.services
{
    internal class Purchase
    {
        static string connectionString = "Data Source=DESKTOP-60OT1H6\\SQLEXPRESS;Initial Catalog=cryptonance;Integrated Security=True";



        public void AddToWalletAndBuyCrypto(models.Crypto crypto, float cryptoAmount, float totalPrice)
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

                            // Update wallet balance
                            string updateWalletQuery = $"UPDATE [wallets] SET {crypto.tag} = {crypto.tag} + @amount WHERE userId = @user_id";
                            SqlCommand updateWalletCommand = new SqlCommand(updateWalletQuery, connection, transaction);
                            updateWalletCommand.Parameters.AddWithValue("@user_id", AppState.CurrentUser.id);
                            updateWalletCommand.Parameters.AddWithValue("@amount", cryptoAmount);
                            updateWalletCommand.ExecuteNonQuery();

                            // Insert into purchase table
                            string insertPurchaseQuery = "INSERT INTO [transactions] (userId, type, cryptoName, cryptoAmount, totalPrice) VALUES (@userId, @type, @cryptoName, @amount, @price)";
                            SqlCommand insertPurchaseCommand = new SqlCommand(insertPurchaseQuery, connection, transaction);
                            insertPurchaseCommand.Parameters.AddWithValue("@userId", AppState.CurrentUser.id);
                            insertPurchaseCommand.Parameters.AddWithValue("@cryptoName", crypto.name);
                            insertPurchaseCommand.Parameters.AddWithValue("@amount", cryptoAmount);
                            insertPurchaseCommand.Parameters.AddWithValue("@price", totalPrice);
                            insertPurchaseCommand.Parameters.AddWithValue("@type", "Buy");
                            insertPurchaseCommand.ExecuteNonQuery();

                            transaction.Commit();

                            AppState.Wallet.addAmount(cryptoAmount, crypto.tag);
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

        public void SaleCrypto(models.Crypto crypto, float cryptoAmount, float totalPrice)
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
                            // Update wallet balance
                            string updateWalletQuery = $"UPDATE [wallets] SET {crypto.tag} = {crypto.tag} - @amount WHERE userId = @user_id";
                            SqlCommand updateWalletCommand = new SqlCommand(updateWalletQuery, connection, transaction);
                            updateWalletCommand.Parameters.AddWithValue("@user_id", AppState.CurrentUser.id);
                            updateWalletCommand.Parameters.AddWithValue("@amount", cryptoAmount);
                            updateWalletCommand.ExecuteNonQuery();
                            // Insert into purchase table
                            string insertPurchaseQuery = "INSERT INTO [transactions] (userId, type, cryptoName, cryptoAmount, totalPrice) VALUES (@userId, @type, @cryptoName, @amount, @price)";
                            SqlCommand insertPurchaseCommand = new SqlCommand(insertPurchaseQuery, connection, transaction);
                            insertPurchaseCommand.Parameters.AddWithValue("@userId", AppState.CurrentUser.id);
                            insertPurchaseCommand.Parameters.AddWithValue("@cryptoName", crypto.name);
                            insertPurchaseCommand.Parameters.AddWithValue("@amount", cryptoAmount);
                            insertPurchaseCommand.Parameters.AddWithValue("@price", totalPrice);
                            insertPurchaseCommand.Parameters.AddWithValue("@type", "Sell");
                            insertPurchaseCommand.ExecuteNonQuery();
                            transaction.Commit();
                            AppState.Wallet.removeAmount(cryptoAmount, crypto.tag);
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
