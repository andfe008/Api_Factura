using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Facturas
    {

        [Key]
        public int idFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int iva { get; set; }
        public double total { get; set; }
        public int idPago { get; set; }

        //public virtual ModoPago ModoPago { get; set; }


    }

}
