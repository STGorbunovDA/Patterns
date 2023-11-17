using FactoryMethod.Classes.Realization.Base;

namespace FactoryMethod.Classes.Realization;

class PanelHouse : House
{
    public PanelHouse()
    {
        Console.WriteLine("Панельный дом построен");
    }
}
