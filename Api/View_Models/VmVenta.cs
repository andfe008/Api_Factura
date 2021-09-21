using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.View_Models.Models
{
    public class VmVenta
    {

        public int idVenta { get; set; }
        public float Total { get; set; }
        public int idCliente { get; set; }
        public int idVendedor { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }

        public virtual VmCliente Cliente { get; set; }
        public virtual VmVendedor Vendedor { get; set; }


    }
}
