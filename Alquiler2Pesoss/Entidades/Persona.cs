using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Alquiler2Pesoss.Entidades
{
    [Index(nameof(DNI), Name = " Codigo_UNQ", IsUnique = true)]

    public class Persona
    {

        [Required]
        [MaxLength(50, ErrorMessage = "El Nombre no debe superar los {50} caracteres")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "La Contraseña no debe superar los {50} caracteres")]
        public string Contraseña { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El Mail no debe superar los {50} caracteres")]
        public string Mail { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "El DNI no debe superar los {15} caracteres")]
        public string DNI { get; set; }    

        [Required]
        [MaxLength(20, ErrorMessage = "El Numero de telefono no debe superar los {20} caracteres")]
        public string NumeroTelefono { get; set; }

        

        [Required]
        [MaxLength(8, ErrorMessage = " La Fecha de nacimiento no debe superar los {8} caracteres")]
        public string FechaNacimiento { get; set; }




    }
}
