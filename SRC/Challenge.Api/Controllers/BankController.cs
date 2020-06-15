using System.Collections.Generic;
using Challenge.Domain;
using Challenge.Domain.Commands.BankCommands;
using Challenge.Domain.CommandsHandlers.BankCommandsHandlers;
using Challenge.Domain.CommandsResults;
using Challenge.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers
{
    [ApiController]
    [Route("v1/banks")]
    public class BankController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Bank> GetAll([FromServices] IBankRepository bankRepository)
        {
            return bankRepository.GetAll();
        }
        [Route("")]
        [HttpPost]
        public CommandResults CreateMarca([FromBody] CreateBankCommand command, [FromServices] BankCommandHandler handler)
        {
            return (CommandResults)handler.Handle(command);
        }
    }
}