using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Modelos
{
    public class CorteCejas : Servicio
    {
        public CorteCejas() : base("Corte de Cejas", 100, 15)
        {
        }

        public override double CalcularPrecio()
        {
            return PrecioBase;
        }
    }
}
