using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Producto
    {
        [Key]
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public float PrecioInitario { get; set; }
        public int idCategoria { get; set; }
        public int Cantidad { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}
