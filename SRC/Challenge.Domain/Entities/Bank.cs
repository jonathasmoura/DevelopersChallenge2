
using System.Collections.Generic;
using Challenge.Shared.Entities;
using Flunt.Notifications;

namespace Challenge.Domain.Entities
{
    public class Bank : Entity
    {
        public Bank() { }

        public Bank(string name)
        {
            BankName = name;
        }
        public string BankName { get; set; }
        public ICollection<BankAccount> Accounts { get; set; }
        public void Activate() => IsActive = true;
        public void Inactivate() => IsActive = false;

    }
}
