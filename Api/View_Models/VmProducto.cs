using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.View_Models.Models
{
    public class VmProducto
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public float PrecioInitario { get; set; }
        public int idCategoria { get; set; }
        public int Cantidad { get; set; }

        public virtual VmCategoria Categoria { get; set; }

    }
}
