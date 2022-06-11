using Alquiler2Pesoss.Entidades;

namespace Alquiler2Pesoss.Servicios
{
    public class AlquilerServicio : IAlquilerServicio
    {
        private readonly HttpClient _http;
        public AlquilerServicio(HttpClient http)
        {
            
        }
        
        
        public List<Producto> Productos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        }
    }

