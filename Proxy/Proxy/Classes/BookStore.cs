using Proxy.Classes.Data;
using Proxy.Interface;

namespace Proxy.Classes;

class BookStore : IBook
{
    PageContext db;
    public BookStore()
    {
        db = new PageContext();
    }
    public Page GetPage(int number)
    {
        try
        {
            return db.Pages.FirstOrDefault(p => p.Number == number);
        }
        catch (Exception)
        {
            return new Page { Id = 1, Number = number, Text = $"мы страницу № {number}" };
        }
        
    }

    public void Dispose()
    {
        db.Dispose();
    }
}
