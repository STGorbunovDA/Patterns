namespace Flyweight.Classes;

class HouseFactory
{
    Dictionary<string, House> Houses = new();
    public HouseFactory()
    {
        Houses.Add("Panel", new PanelHouse());
        Houses.Add("Brick", new BrickHouse());
    }

    public House GetHouse(string key)
    {
        if (Houses.ContainsKey(key))
            return Houses[key];
        else
            return null;
    }
}
