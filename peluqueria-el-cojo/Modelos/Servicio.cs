using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Modelos
{
    public class Servicio
    {
        public string Nombre { get; set; }
        public double PrecioBase { get; set; }
        public int Duracion { get; set; }

        public Servicio(string nombre, double precioBase, int duracion)
        {
            Nombre = nombre;
            PrecioBase = precioBase;
            Duracion = duracion;
        }

        public virtual double CalcularPrecio()
        {
            return PrecioBase;
        }
    }
}
