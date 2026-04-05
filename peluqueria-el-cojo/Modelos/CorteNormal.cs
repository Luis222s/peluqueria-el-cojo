using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Modelos
{
    public class CorteNormal : Servicio
    {
        public CorteNormal() : base("Corte Normal", 200, 30)
        {
        }

        public override double CalcularPrecio()
        {
            return PrecioBase;
        }
    }
}
