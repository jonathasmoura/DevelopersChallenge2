using System;
using Challenge.Shared.Commands;

namespace Challenge.Domain.Commands.BankCommands
{
    public class CreateBankCommands : ICommand
    {
        public CreateBankCommands() { }
        public CreateBankCommands(int id, string name) { Id = new int(); Name = name; }
        public int Id { get; set; }
        public string Name { get; set; }
        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
