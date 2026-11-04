namespace OliveBranchBakes.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PreferredPickupNotes { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public Customer()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            PreferredPickupNotes = string.Empty;
            PasswordHash = string.Empty;
            PasswordSalt = string.Empty;
        }

        public string FullName
        {
            get { return (FirstName + " " + LastName).Trim(); }
        }
    }
}
