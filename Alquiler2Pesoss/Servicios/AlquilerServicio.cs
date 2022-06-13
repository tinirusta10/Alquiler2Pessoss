using Alquiler2Pesoss.Entidades;
using Microsoft.AspNetCore.Components;

namespace Alquiler2Pesoss.Servicios
{
    public class AlquilerServicio : IAlquilerServicio
    {
        private readonly HttpClient _http;
  



        public List<Producto> Productos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task CrearProducto(Producto producto)
        {
            var resultado = await _http.PostAsJsonAsync("api/producto", producto);
            await EstablecerProductos(resultado);
        }

        private async Task EstablecerProductos(HttpResponseMessage resultado)
        {
            var response = await resultado.Content.ReadFromJsonAsync<List<Producto>>();
            Productos = response;

        }

        public async Task BorrarProducto(int id)
        {
            var resultado = await _http.DeleteAsync($"api/producto{id}");
             await EstablecerProductos(resultado);
        }


        public async Task<Producto> MostrarUnProducto(int id)
        {
            var resultado = await _http.GetFromJsonAsync<Producto>($"api/producto/{id}");
            if (resultado != null)
                return resultado;
            throw new  Exception("producto no encontrado!");
        }


        public async Task MostrarProductos()
        {
            var resultado = await _http.GetFromJsonAsync<List<Producto>>($"api/producto");
            if (resultado != null)
            Productos = resultado;
        }

        public async Task ActualizarProducto(Producto producto)
        {
            var resultado = await _http.PutAsJsonAsync($"api/producto/{producto.Id}", producto);
            await EstablecerProductos(resultado);
        }

        public Task GetProducto()
        {
            throw new NotImplementedException();
        }

        public Task<Producto> GetSingleProducto(int id)
        {
            throw new NotImplementedException();
        }

        public Task CreateProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProducto(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
    }

