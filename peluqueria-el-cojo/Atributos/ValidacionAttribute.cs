using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Atributos
{
    public abstract class ValidacionAttribute : Attribute
    {
        public abstract bool EsValido(object valor);
        public abstract string MensajeError { get; }
    }
}
