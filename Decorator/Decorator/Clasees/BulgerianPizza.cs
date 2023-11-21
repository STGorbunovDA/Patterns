namespace Decorator.Clasees;

class BulgerianPizza : Pizza
{
    public BulgerianPizza(): base("Болгарская пицца") { }
    public override int GetCost()
    {
        return 8;
    }
}
