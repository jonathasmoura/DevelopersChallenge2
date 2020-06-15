namespace Challenge.Domain.Entities
{
    public class Extract
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int BankAccounId { get; set; }
        public int ExtractSignOnId { get; set; }
        public ExtractSignOn ExtractSignOn { get; set; }
        public BankAccount BanckAccount { get; set; }
    }
}
