using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using cryptonance.state;

namespace cryptonance.services
{
    internal class Trade
    {
        static string connectionString = "Data Source=DESKTOP-60OT1H6\\SQLEXPRESS;Initial Catalog=cryptonance;Integrated Security=True";


        public void ExchangeCrypto(models.Crypto fromCrypto, models.Crypto toCrypto, float amount, float convertedAmount)
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
                            string updateWalletQuery = $"UPDATE [wallets] SET {fromCrypto.tag} = {fromCrypto.tag} - @amount, {toCrypto.tag} = {toCrypto.tag} + @convertedAmount WHERE userId = @user_id";
                            SqlCommand updateWalletCommand = new SqlCommand(updateWalletQuery, connection, transaction);
                            updateWalletCommand.Parameters.AddWithValue("@user_id", AppState.CurrentUser.id);
                            updateWalletCommand.Parameters.AddWithValue("@amount", amount);
                            updateWalletCommand.Parameters.AddWithValue("@convertedAmount", convertedAmount);
                            updateWalletCommand.ExecuteNonQuery();
                           
                            transaction.Commit();
                            AppState.Wallet.addAmount(convertedAmount, toCrypto.tag);
                            AppState.Wallet.removeAmount(amount, fromCrypto.tag);
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
