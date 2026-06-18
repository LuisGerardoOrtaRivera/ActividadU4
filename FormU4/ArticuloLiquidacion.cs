using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormU4
{
    public class ArticuloLiquidacion: Articulo, ICobrable
    {
        public double CalcularTotal()
        {
            return PrecioBase * 0.50; // Aplica 50% de descuento automático
        }
    }
}
