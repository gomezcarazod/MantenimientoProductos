using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoProducto
{
    public class Producto
    {

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int CodigoCategoria { get; set; }
        public Categoria Category;
        public double Precio { get; set; }
    }
}
