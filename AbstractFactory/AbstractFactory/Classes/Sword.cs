using AbstractFactory.Classes.Base;

namespace AbstractFactory.Classes;

// класс меч
class Sword : Weapon
{
    public override void Strike()
    {
        Console.WriteLine("Бьем мечом");
    }
}
