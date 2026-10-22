namespace OliveBranchBakes.Models
{
    
    // Represents an administrator account for the bakery console.
    
    
    public class AdminUser
    {
        public int AdminId { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }

        public AdminUser()
        {
            Username = string.Empty;
            DisplayName = string.Empty;
            IsActive = true;
        }
    }
}
