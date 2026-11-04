using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public static class Session
    {
        public static Customer CurrentCustomer { get; set; }

        public static bool IsSignedIn
        {
            get { return CurrentCustomer != null; }
        }

        public static void SignOut()
        {
            CurrentCustomer = null;
        }
    }
}
