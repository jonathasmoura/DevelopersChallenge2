using System;

namespace Challenge.Shared.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {
        ICommandResults Handle(T command);
    }
}
