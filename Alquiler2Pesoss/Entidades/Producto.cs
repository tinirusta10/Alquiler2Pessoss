
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Alquiler2Pesoss.Entidades
{

[Index(nameof(Id), Name = " Codigo_UNQ", IsUnique = true)]


public class Producto
    {
        [Required]
        [MaxLength(2, ErrorMessage = "El Código del producto no debe superar los {1} caracteres")]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(20, ErrorMessage = "El nombre del producto no debe superar los {1} caracteres")]
        
        public string Nombre { get; set; }
        
        [Required]
        [MaxLength(20, ErrorMessage = "El precio del producto no debe superar los {1} caracteres")]

        public int Precio { get; set; }
        
        [Required]
        [MaxLength(300, ErrorMessage = "El numero de caracteres no debe superar los {1} ")]

        public string Detalles { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "No se pueden subir mas de {1} fotos")]

        public string Foto { get; set; }
        [Required]

        public string UsuarioDueño { get; set; }
        [Required]
        [MaxLength(8, ErrorMessage = "Inrese una fecha correcta")]
        public DateTime FechaPublicacion { get; set; }

       


    }


}
