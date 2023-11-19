using AbstractFactory.Classes.Base;

namespace AbstractFactory.Classes;

// движение полета
class FlyMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Летим");
    }
}
