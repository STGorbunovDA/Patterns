using Command.Interfaces;

namespace Command.Classes;

public class MicrowaveCommand : ICommand
{
    Microwave microwave;
    int time;
    public MicrowaveCommand(Microwave microwave, int time)
    {
        microwave = microwave;
        time = time;
    }
    public void Execute()
    {
        microwave.StartCooking(time);
        microwave.StopCooking();
    }

    public void Undo()
    {
        microwave.StopCooking();
    }
}
