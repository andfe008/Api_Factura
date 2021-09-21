using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Vendedor
    {
        [Key]
        public int idVendedor { get; set; }
        public string Nick { get; set; }
        public int NumeroVendedor { get; set; }


        public virtual ICollection<Venta> Venta { get; set; }

    }
}
