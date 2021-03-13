namespace ShoppingCommand.Command
{
    public interface ICommand
    {
        bool CanExecute();
        void Execute();
        void Undo();
    }
}
