using Alquiler2Pesoss.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Alquiler2Pesoss.Entidades
{
    public class Departamento
    {
        [Key]
        public int Id{ get; set; }

        public string NombreDepartamento { get; set; }

    }
}
