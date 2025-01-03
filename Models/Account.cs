namespace BankingAppMVCEntity.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }  // Foreign key to Customer
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }

        // Navigation Property to Customer
        public Customer Customer { get; set; }
    }

}
