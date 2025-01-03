namespace BankingAppMVCEntity.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public int CustomerId { get; set; }  // Foreign key to Customer
        public string LoanType { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }

        // Navigation Property to Customer
        public Customer Customer { get; set; }
    }

}
