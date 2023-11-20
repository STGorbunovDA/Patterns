using Adapter.Interfaces;

namespace Adapter.Classes;

class Driver
{
    public void Travel(ITransport transport)
    {
        transport.Drive();
    }
}
