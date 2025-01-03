namespace BankingAppMVCEntity.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }  // Foreign key to Account
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal BalanceAfter { get; set; }
        public string Description { get; set; }

        // Navigation Property to Account
        public Account Account { get; set; }
    }

}
