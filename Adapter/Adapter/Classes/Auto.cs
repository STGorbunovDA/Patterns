using Adapter.Interfaces;

namespace Adapter.Classes;

class Auto : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Машина едет по дороге");
    }
}
