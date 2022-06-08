using Alquiler2Pesoss.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Alquiler2Pesoss.Entidades
{
    public class TipoDocumento
    {

        public int Id{ get; set; }

        public string NombreTipoDocumento { get; set; }

    }
}
