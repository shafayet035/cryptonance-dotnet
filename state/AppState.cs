

namespace cryptonance.state
{
   internal static class AppState
    {
        public static models.User CurrentUser { get; set; }
        public static bool IsUserLoggedIn { get; set; }
    }
}
