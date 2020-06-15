namespace Challenge.Domain.Entities
{
    public class Transaction
    {
        public ETransactionType TransctionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public long CheckNum { get; set; }
        public double TransactionValue { get; set; }
        public string Description { get; set; }
    }
}
