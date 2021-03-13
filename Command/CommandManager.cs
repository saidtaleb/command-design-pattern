namespace ShoppingCommand.Command
{
    using System.Collections.Generic;

    public class CommandManager
    {
        private readonly Stack<ICommand> _commands = new Stack<ICommand>();

        public void Invoke(ICommand command)
        {
            if (command.CanExecute())
            {
                command.Execute();
                _commands.Push(command);
            }
        }

        public void Undo()
        {
            if (_commands.TryPop(out var command))
                command.Undo();
        }
    }
}
