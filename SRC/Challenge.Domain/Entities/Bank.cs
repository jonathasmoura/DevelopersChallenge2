
using Challenge.Shared.Entities;
using Flunt.Notifications;

namespace Challenge.Domain.Entities
{
    public class Bank : Entity
    {
        public Bank() { }

       
        public string BankName { get; set; }
        public bool Active { get; set; }
    }
}
