
namespace Challenge.Domain.Entities
{
    public class BankAccount
    {
        public EAccountType AccountType { get; set; }
        public int BankId { get; set; }
        public string Agency { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
