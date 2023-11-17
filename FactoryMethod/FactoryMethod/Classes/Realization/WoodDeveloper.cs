using FactoryMethod.Classes.Realization.Base;

namespace FactoryMethod.Classes.Realization;

// строит деревянные дома
class WoodDeveloper : Developer
{
    public WoodDeveloper(string n) : base(n)
    { }

    public override House Create()
    {
        return new WoodHouse();
    }
}
