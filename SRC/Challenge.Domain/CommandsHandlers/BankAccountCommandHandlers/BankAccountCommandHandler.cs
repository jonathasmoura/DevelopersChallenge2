using System;
using Challenge.Domain.Commands.BankAccountCommands;
using Challenge.Domain.Commands.BankCommands;
using Challenge.Domain.CommandsResults;
using Challenge.Domain.Entities;
using Challenge.Shared.Commands;
using Flunt.Notifications;

namespace Challenge.Domain.CommandsHandlers.BankAccountCommandsHandlers
{
    public class BankAccountCommandHandler : Notifiable, ICommandHandler<CreateAccountCommand>
    {
        private readonly IBankRepository _bankRepository;
        private readonly IBankAccountRepository _bankAccountRepository;
        public BankAccountCommandHandler(IBankRepository bankRepository, IBankAccountRepository bankAccountRepository)
        {
            _bankRepository = bankRepository;
            _bankAccountRepository = bankAccountRepository;
        }

        public ICommandResults Handle(CreateAccountCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new CommandResults(false, "Ops, não foi possível cadastrar seu registro.", command.Notifications);
            var acc = _bankAccountRepository.GetById(command.Id);

            if (_bankAccountRepository.AccountExists(acc.Id))
                return new CommandResults(false, "Não é possível realizar o cadastro!", command);

            var bank = _bankRepository.GetById(command.BankId);
            var accountCreate = new BankAccount(
                command.AccountType,
                bank.Id,
                command.Agency);

            AddNotifications(accountCreate.Notifications);
            if (Invalid)
                return new CommandResults(false, "Não foi possível realizar o cadastro de conta nova!!", command.Notifications);
            _bankAccountRepository.Create(accountCreate);
            _bankAccountRepository.Save();

            return new CommandResults(true, "Conta registrada com sucesso!!!", command);
        }
    }
}
