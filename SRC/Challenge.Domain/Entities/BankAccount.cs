using Challenge.Domain.Enums;

namespace Challenge.Domain.Entities
{
    public class BankAccount
    {
        public BankAccount(){}
        public BankAccount(EAcountType accountType, int bankId, string agency)
        {
            AccountType = accountType;
            BankId = bankId;
            Agency = agency;
        }

        public EAcountType AccountType { get; set; }
        public int BankId { get; set; }
        public string Agency { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
