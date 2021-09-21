using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.View_Models.Models
{
    public class VmCliente
    {

        public int idCliente { get; set; }

        public string Nombre { get; set; }
        public string Documento  { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<VmVenta> Venta { get; set; }

    }
}
