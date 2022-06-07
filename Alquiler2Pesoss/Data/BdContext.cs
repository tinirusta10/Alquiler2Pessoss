using Alquiler2Pesoss.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Alquiler2Pesoss.Data
{
    public class BdContext :DbContext
    {
        public BdContext(DbContextOptions<BdContext> options) : base(options) { }

        public DbSet <Producto> productos { get; set; }

       

    }
}
