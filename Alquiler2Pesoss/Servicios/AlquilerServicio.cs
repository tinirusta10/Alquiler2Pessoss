using Alquiler2Pesoss.Entidades;
using Microsoft.AspNetCore.Components;

namespace Alquiler2Pesoss.Servicios
{
    public class AlquilerServicio : IAlquilerServicio
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public AlquilerServicio(HttpClient http NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        
        
        public List<Producto> Productos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task CreateProducto(Producto producto)
        {
            var result = await _http.PostAsJsonAsync("api/producto", producto);
            await SetProductos(result);
        }

        private async Task SetProductos(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Producto>>();
            Productos = response;
            _navigationManager.NavigateTo("Producto");
        }

        public async Task DeleteProducto(int id)
        {
            var result = await _http.DeleteAsync($"api/producto{id}");
             await SetProductos(result);
        }


        public async Task<Producto> GetSingleProducto(int id)
        {
            var result = await _http.GetFromJsonAsync<Producto>($"api/producto/{id}");
            if (result != null)
                return result;
            throw new  Exception("producto no funciona!");
        }


        public async Task GetProducto()
        {
            var result = await _http.GetFromJsonAsync<List<Producto>>($"api/producto");
            if (result != null)
            Productos = result;
        }

        public async Task UpdateProducto(Producto producto)
        {
            var result = await _http.PutAsJsonAsync($"api/producto/{producto.Id}", producto);
            await SetProductos(result);
        }
    }
    }

