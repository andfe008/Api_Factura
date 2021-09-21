using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Cliente
    {

        [Key]
        public int idCliente { get; set; }

        public string Nombre { get; set; }
        public string Documento  { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Venta> Venta { get; set; }

    }
}
