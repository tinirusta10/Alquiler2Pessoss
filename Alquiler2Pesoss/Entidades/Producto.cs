
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Alquiler2Pesoss.Entidades
{

[Index(nameof(Id), Name = " Codigo_UNQ", IsUnique = true)]


public class Producto
    {
        [Required]
        [MaxLength(200, ErrorMessage = "El Código del producto no debe superar los {200} caracteres")]
        public int Id { get; set; }
        

        [Required]
        [MaxLength(50, ErrorMessage = "El nombre del producto no debe superar los {50} caracteres")]
        public string Nombre { get; set; }
        


        [Required]
        [MaxLength(20, ErrorMessage = "El precio del producto no debe superar los {20} caracteres")]
        public int Precio { get; set; }
        

        [Required]
        [MaxLength(300, ErrorMessage = "El numero de caracteres no debe superar los {300} ")]
        public string Detalles { get; set; }


        [Required]
       [MaxLength(10, ErrorMessage = "No se pueden subir mas de {10} fotos")]
        public string Foto { get; set; }


        [Required]
        [MaxLength(50, ErrorMessage = "El numero de caracteres no debe superar los {50} ")]
        public string UsuarioDueño { get; set; }


        [Required]
        [MaxLength(8, ErrorMessage = "Ingrese una fecha correcta")]
        public DateTime FechaPublicacion { get; set; }

       


    }


}
