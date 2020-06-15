using System;
using Challenge.Domain.Enums;
using Challenge.Shared.Commands;
using Flunt.Notifications;

namespace Challenge.Domain.Commands.BankAccountCommands
{
    public class CreateAccountCommand : Notifiable, ICommand
    {
        public CreateAccountCommand() { }
        public Guid Id { get; set; }
        public Guid BankId { get; set; }
        public string Agency { get; set; }
        public EAcountType AccountType { get; set; }

        public void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
