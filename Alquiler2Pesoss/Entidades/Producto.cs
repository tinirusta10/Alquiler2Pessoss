﻿
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Alquiler2Pesoss.Entidades
{




public class Producto
    {
        [Required]
        [MaxLength(10)]
        public int Id { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "El Nombre no debe superar los 50 caracteres")]
        public string NombreProducto { get; set; }



        [Required]
        [MaxLength(20)]
        public int PrecioProducto { get; set; }
        

        [Required]
        [MaxLength(300, ErrorMessage = "El numero de caracteres no debe superar los 300 ")]
        public string DetallesProducto { get; set; }


        [Required]
       [MaxLength(10, ErrorMessage = "No se pueden subir mas de 10 fotos")]
        public string FotoProducto { get; set; }





       


    }


}
