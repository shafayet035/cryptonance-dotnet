

namespace cryptonance.state
{
   internal static class AppState
    {
        public static models.User CurrentUser { get; set; }
        public static bool IsUserLoggedIn { get; set; }

        public static models.Wallet Wallet { get; set; }

        public static List<models.Crypto> Cryptos { get; set; } = new List<models.Crypto>();

    }
}
