using Alquiler2Pesoss.Entidades;

namespace Alquiler2Pesoss.Servicios
{
    public interface IAlquilerServicio
    {

        List<Producto> Productos { get; set; }


        Task GetProducto();



       Task<Producto> GetSingleProducto(int id);

        Task CreateProducto(Producto producto);

        Task UpdateProducto (Producto producto);

        Task DeleteProducto(int id);

    }
}
