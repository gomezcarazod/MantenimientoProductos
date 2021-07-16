using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoProducto
{
    public class Categoria
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
