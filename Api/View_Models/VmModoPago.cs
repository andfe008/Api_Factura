using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.View_Models.Models
{
    public class VmModoPago
    {

        public int idPago { get; set; }
        public string Nombre { get; set; }
        public string Detalles { get; set; }
        public virtual ICollection<VmFacturas> Facturas { get; set; }

    }
}
