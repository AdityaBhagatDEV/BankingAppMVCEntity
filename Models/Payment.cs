namespace BankingAppMVCEntity.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int LoanId { get; set; }  // Foreign key to Loan
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal BalanceAfter { get; set; }
        public string PaymentMethod { get; set; }

        // Navigation Property to Loan
        public Loan Loan { get; set; }
    }

}
