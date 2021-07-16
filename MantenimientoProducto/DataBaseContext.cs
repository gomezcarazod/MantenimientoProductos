using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoProducto
{
    public class DataBaseContext
    {
        public DataBaseContext()
        {
            this.Productos = new List<Producto>()
            {
                new Producto(){Codigo = 1, Descripcion ="televisor",
                                CodigoCategoria = 1, Precio = 12000.00},
                 new Producto(){Codigo = 2, Descripcion ="Lavadora",
                                CodigoCategoria = 1, Precio = 12000.00},
                  new Producto(){Codigo = 3, Descripcion ="Componente",
                                CodigoCategoria = 1, Precio = 12000.00},
                   new Producto(){Codigo = 4, Descripcion ="Liquadora",
                                CodigoCategoria = 1, Precio = 12000.00}
            };

        }

        public List<Producto> Productos;
    }
}
