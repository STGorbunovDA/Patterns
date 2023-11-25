using Command.Interfaces;

namespace Command.Classes;

// Invoker - инициатор
class Pult
{
    ICommand command;

    public Pult() { }

    public void SetCommand(ICommand com)
    {
        command = com;
    }

    public void PressButton()
    {
        if (command != null)
            command.Execute();
    }
    public void PressUndo()
    {
        if (command != null)
            command.Undo();
    }
}
