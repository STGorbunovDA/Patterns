namespace Flyweight.Classes;

abstract class House
{
    protected int stages; // количество этажей

    // долгота и широта
    public abstract void Build(double longitude, double latitude);
}
