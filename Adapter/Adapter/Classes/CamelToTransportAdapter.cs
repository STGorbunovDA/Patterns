using Adapter.Interfaces;

namespace Adapter.Classes;

// Адаптер от Camel к ITransport
class CamelToTransportAdapter : ITransport
{
    Camel camel;
    public CamelToTransportAdapter(Camel c)
    {
        camel = c;
    }

    public void Drive()
    {
        camel.Move();
    }
}
