using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.View_Models.Models
{
    public class VmDetalle_Venta
    {

        public int idDetalle { get; set; }
        public int idFactura { get; set; }
        public int idVenta { get; set; }
        public float subTotal { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }

        public virtual VmFacturas Facturas { get; set; }
        public virtual VmProducto Producto { get; set; }
        public virtual VmVenta Venta { get; set; }

    }
}
