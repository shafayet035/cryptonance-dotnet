

namespace cryptonance.state
{
   internal static class AppState
    {
        public static string connectionString = "Data Source=DESKTOP-60OT1H6\\SQLEXPRESS;Initial Catalog=cryptonance;Integrated Security=True";
        public static models.User CurrentUser { get; set; }

        public static List<models.User> Users { get; set; } = new List<models.User>();
        public static bool IsUserLoggedIn { get; set; }

        public static models.Wallet Wallet { get; set; }

        public static List<models.Crypto> Cryptos { get; set; } = new List<models.Crypto>();
        public static List<models.Transaction> Transactions { get; set; } = new List<models.Transaction>();

    }
}
