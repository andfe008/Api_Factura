using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Detalle_Venta
    {

        [Key]
        public int idDetalle { get; set; }
        public int idFactura { get; set; }
        public int idVenta { get; set; }
        public float subTotal { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }

        public virtual Facturas Facturas { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }

    }
}
