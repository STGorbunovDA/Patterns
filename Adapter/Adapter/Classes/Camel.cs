using Adapter.Interfaces;

namespace Adapter.Classes;

class Camel : IAnimal
{
    public void Move()
    {
        Console.WriteLine("Верблюд идет по пескам пустыни");
    }
}
