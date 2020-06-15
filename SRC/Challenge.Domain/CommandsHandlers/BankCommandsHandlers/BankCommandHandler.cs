using System;
using Challenge.Domain.Commands.BankCommands;
using Challenge.Domain.CommandsResults;
using Challenge.Domain.Entities;
using Challenge.Shared.Commands;
using Flunt.Notifications;

namespace Challenge.Domain.CommandsHandlers.BankCommandsHandlers
{
    public class BankCommandHandler : Notifiable, ICommandHandler<CreateBankCommand>
    {
        private readonly IBankRepository _bankRepository;
        public BankCommandHandler(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public ICommandResults Handle(CreateBankCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new CommandResults(false, "Ops, não foi possível cadastrar seu registro!", command.Notifications);

                var bk = new Bank(command.Name);

                AddNotifications(bk.Notifications);
                if(Invalid)
                return new CommandResults(false, "Ops, não foi possível cadastrar seu registro!", command);
                _bankRepository.Create(bk);
                
                return new CommandResults(true, "Banco registrado com sucesso!", bk);
        }
    }
}
