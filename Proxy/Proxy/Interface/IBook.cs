using Proxy.Classes;

namespace Proxy.Interface;

interface IBook : IDisposable
{
    Page GetPage(int number);
}
