using System;
using Challenge.Shared.Commands;
using Flunt.Notifications;
using Flunt.Validations;

namespace Challenge.Domain.Commands.BankCommands
{
    public class CreateBankCommand : Notifiable, ICommand
    {
        public CreateBankCommand() { }
        public CreateBankCommand(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void Validate()
        {
            AddNotifications(new Contract()
                        .Requires().HasMinLen(Name, 3, "CreateBankCommand.Name", "Nome deve conter no mínimo 3 caracteres")
                        .HasMaxLen(Name, 50, "CreateBankCommand.Name", "Nome deve conter no máximo 140 caracteres"));
        }
    }
}
