using AbstractFactory.Classes.Base;

namespace AbstractFactory.Classes;

// движение - бег
class RunMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Бежим");
    }
}
