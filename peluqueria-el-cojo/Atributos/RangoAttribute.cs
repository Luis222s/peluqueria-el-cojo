using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Atributos
{
    public class RangoAttribute : ValidacionAttribute
    {
        public double Min { get; }
        public double Max { get; }

        public override string MensajeError => $"El valor debe estar entre {Min} y {Max}";

        public RangoAttribute(double min, double max)
        {
            Min = min;
            Max = max;
        }

        public override bool EsValido(object valor)
        {
            if (valor == null) return false;

            double numero = Convert.ToDouble(valor);
            return numero >= Min && numero <= Max;
        }
    }
}
