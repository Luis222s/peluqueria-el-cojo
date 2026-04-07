using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Atributos
{
    public class RequeridoAttribute : ValidacionAttribute
    {
        public override string MensajeError => "El campo es requerido";

        public override bool EsValido(object valor)
        {
            if (valor == null) return false;

            if (valor is string str)
                return !string.IsNullOrWhiteSpace(str);

            return true;
        }
    }
}
