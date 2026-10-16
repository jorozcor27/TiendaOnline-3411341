using Microsoft.EntityFrameworkCore;
using TiendaOnline.API.Models;

namespace TiendaOnline.API.Data
{
    public class TiendaOnlineDbContext : DbContext
    {
        public TiendaOnlineDbContext(DbContextOptions<TiendaOnlineDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        
    }
}
