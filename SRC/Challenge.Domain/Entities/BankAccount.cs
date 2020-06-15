using Challenge.Domain.Enums;
using Challenge.Shared.Entities;
using Flunt.Notifications;

namespace Challenge.Domain.Entities
{
    public class BankAccount : Entity
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
