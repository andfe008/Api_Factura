using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Venta
    {

        [Key]
        public int idVenta { get; set; }
        public float Total { get; set; }
        public int idCliente { get; set; }
        public int idVendedor { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Vendedor Vendedor { get; set; }


    }
}
