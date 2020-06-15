using Challenge.Domain.CommandsHandlers.BankAccountCommandsHandlers;
using Challenge.Domain.Commands.BankAccountCommands;
using Challenge.Domain.CommandsResults;
using System.Collections.Generic;
using Challenge.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Challenge.Domain;

namespace Challenge.Api.Controllers
{
    [ApiController]
    [Route("v1/accounts")]
    public class BankAccountController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<BankAccount> GetAll([FromServices] IBankAccountRepository bankAccountRepository)
        {
            return bankAccountRepository.GetAll();
        }
        [Route("")]
        [HttpPost]
        public CommandResults CreateAccount([FromBody] CreateAccountCommand command, [FromServices] BankAccountCommandHandler handler)
        {
            return (CommandResults)handler.Handle(command);
        }
    }
}