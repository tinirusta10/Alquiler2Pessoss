using Alquiler2Pesoss.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Alquiler2Pesoss.Data
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Persona> personaEnt { get; set; }

        public DbSet<Producto> productoEnt { get; set; }






    }
}
