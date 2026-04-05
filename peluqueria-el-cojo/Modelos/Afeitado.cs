using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Modelos
{
    public class Afeitado : Servicio
    {
        public bool ToallaCaliente { get; set; }

        public Afeitado(bool toallaCaliente) : base("Afeitado", 150, 20)
        {
            ToallaCaliente = toallaCaliente;
        }

        public override double CalcularPrecio()
        {
            double extra = ToallaCaliente ? 50 : 0;
            return PrecioBase + extra;
        }
    }
}
