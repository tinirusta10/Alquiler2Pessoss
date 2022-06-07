using System.ComponentModel.DataAnnotations;

namespace Alquiler2Pesoss.Entidades
{
    public class Producto
    {
        [Required]
        public int id { get; set; }

        public string Nombre { get; set; }




    }


}
