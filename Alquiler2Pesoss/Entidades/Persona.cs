using Alquiler2Pesoss.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Alquiler2Pesoss.Entidades
{
    [Index(nameof(Id), Name = "personassDNI_UQ", IsUnique = true)]

    public class Persona
    {
        [Required]
        [MaxLength(8, ErrorMessage = "El DNI de la persona no debe superar los {1} caracteres")]
        [Key]
        public string Id { get; set; }


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
        [MaxLength(20, ErrorMessage = "El Numero de telefono no debe superar los {20} caracteres")]
        public string NumeroTelefono { get; set; }



        [Required]
        [MaxLength(8, ErrorMessage = " La Fecha de nacimiento no debe superar los {8} caracteres")]
        public string FechaNacimiento { get; set; }




    }
}
