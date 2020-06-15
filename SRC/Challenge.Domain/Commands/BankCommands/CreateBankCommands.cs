using System;
using Challenge.Shared.Commands;
using Flunt.Notifications;

namespace Challenge.Domain.Commands.BankCommands
{
    public class CreateBankCommands : Notifiable,ICommand
    {
        public CreateBankCommands() { }
        public CreateBankCommands(int id, string name) { Id = new int(); Name = name; Active = true; }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}