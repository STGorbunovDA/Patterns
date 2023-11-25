namespace Command.Interfaces;

interface ICommand
{
    void Execute();
    void Undo();
}
