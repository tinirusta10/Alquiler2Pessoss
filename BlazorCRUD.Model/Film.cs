using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Model
{
    public class Film
    {
        public int Id { get; set; }
        public string nombre_producto { get; set; }
        public string precio_producto { get; set; }
        public string descripcion_producto { get; set; }
    }
}
