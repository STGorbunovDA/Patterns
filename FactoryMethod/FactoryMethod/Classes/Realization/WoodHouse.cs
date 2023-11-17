using FactoryMethod.Classes.Realization.Base;

namespace FactoryMethod.Classes.Realization;

class WoodHouse : House
{
    public WoodHouse()
    {
        Console.WriteLine("Деревянный дом построен");
    }
}
