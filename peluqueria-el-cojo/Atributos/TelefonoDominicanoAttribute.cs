using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Atributos
{
    public class TelefonoDominicanoAttribute : ValidacionAttribute
    {
        public override string MensajeError => "Teléfono dominicano inválido";

        public override bool EsValido(object valor)
        {
            if (valor == null) return false;

            string tel = valor.ToString();

            return tel.Length == 10 && tel.StartsWith("809") || tel.StartsWith("829") || tel.StartsWith("849");
        }
    }
}
