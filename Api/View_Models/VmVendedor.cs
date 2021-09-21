using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.View_Models.Models
{
    public class VmVendedor
    {
        public int idVendedor { get; set; }
        public string Nick { get; set; }
        public int NumeroVendedor { get; set; }


        public virtual ICollection<VmVenta> Venta { get; set; }

    }
}
