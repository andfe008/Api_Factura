using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ModoPago
    {

        [Key]
        public int idPago { get; set; }
        public string Nombre { get; set; }
        public string Detalles { get; set; }
        //public virtual ICollection<Facturas> Facturas { get; set; }

    }
}
