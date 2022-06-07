using System.ComponentModel.DataAnnotations;

namespace Alquiler2Pesoss.Entidades
{
    public class Producto
    {
        [Required]
        public int id { get; set; }

        public string Nombre { get; set; }

        public int Precio { get; set; }

        public string Detalles { get; set; }

        public string Foto { get; set; }

        public string UsuarioDueño { get; set; }

        public DateTime FechaPublicacion { get; set; }

       


    }


}
