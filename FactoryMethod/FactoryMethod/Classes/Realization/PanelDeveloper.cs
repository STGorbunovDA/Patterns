using FactoryMethod.Classes.Realization.Base;

namespace FactoryMethod.Classes.Realization;

// строит панельные дома
class PanelDeveloper : Developer
{
    public PanelDeveloper(string n) : base(n) { }

    public override House Create()
    {
        return new PanelHouse();
    }
}
