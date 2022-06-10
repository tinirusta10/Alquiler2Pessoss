using Alquiler2Pesoss.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Alquiler2Pesoss.Data
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Persona> TablaPersona { get; set; }

        public DbSet<Producto> TablaPrpducto { get; set; }

        public DbSet <Provincia> TablaProvincia { get; set; }

        public DbSet<Departamento> TablaDepartamento { get; set; }

        public DbSet<TipoDocumento> TablaTipoDocumento { get; set; }

        public DbSet<Localidad> TablaLocalidad { get; set; }





    }
}
