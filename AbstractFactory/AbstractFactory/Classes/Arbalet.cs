using AbstractFactory.Classes.Base;

namespace AbstractFactory.Classes;

// класс арбалет
class Arbalet : Weapon
{
    public override void Strike()
    {
        Console.WriteLine("Стреляем из арбалета");
    }
}

