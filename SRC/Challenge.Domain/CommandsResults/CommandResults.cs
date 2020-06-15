using System;
using Challenge.Shared.Commands;

namespace Challenge.Domain.CommandsResults
{
    public class CommandResults : ICommandResults
    {
        public CommandResults(){}
        public CommandResults(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
