using System;
using Challenge.Domain.Commands.BankCommands;
using Challenge.Domain.CommandsResults;
using Challenge.Shared.Commands;
using Flunt.Notifications;

namespace Challenge.Domain.CommandsHandlers.BankCommandsHandlers
{
    public class BankCommandHandler : Notifiable, ICommandHandler<CreateBankCommands>
    {
        private readonly IBankRepository _bankRepository;
        public BankCommandHandler(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public ICommandResults Handle(CreateBankCommands command)
        {
            throw new NotImplementedException();
        }
    }
}
