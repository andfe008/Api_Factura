using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.View_Models.Models
{
    public class VmFacturas
    {

        public int idFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int iva { get; set; }
        public double total { get; set; }
        public int idPago { get; set; }

        //public virtual VmModoPago ModoPago { get; set; }


    }

}
