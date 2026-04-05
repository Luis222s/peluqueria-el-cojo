using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Modelos
{
    public class Degradado : Servicio
    {
        public int Nivel { get; set; }

        public Degradado(int nivel) : base("Degradado", 300, 40)
        {
            Nivel = nivel;
        }

        public override double CalcularPrecio()
        {
            return PrecioBase + (Nivel * 50);
        }
    }
}
