using Alquiler2Pesoss.Entidades;

namespace Alquiler2Pesoss.Servicios
{
    public interface IAlquilerServicio
    {

        List<Producto> Productos { get; set; }


        Task MostrarProductos();



       Task<Producto> MostrarUnProducto(int id);

        Task CrearProducto(Producto producto);

        Task ActualizarProducto (Producto producto);

        Task BorrarProducto(int id);

    }
}
