using Microsoft.EntityFrameworkCore;

namespace Proxy.Classes.Data;

class PageContext : DbContext
{
    public DbSet<Page> Pages { get; set; }
}
