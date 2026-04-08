using peluqueria_el_cojo.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Utilidades
{
    public class Validador
    {
        public static List<string> Validar(object obj)
        {
            List<string> errores = new List<string>();

            PropertyInfo[] propiedades = obj.GetType().GetProperties();

            foreach (var prop in propiedades)
            {
                object valor = prop.GetValue(obj);

                var atributos = prop.GetCustomAttributes(typeof(ValidacionAttribute), true);

                foreach (ValidacionAttribute atributo in atributos)
                {
                    if (!atributo.EsValido(valor))
                    {
                        errores.Add($"{prop.Name}: {atributo.MensajeError}");
                    }
                }
            }

            return errores;
        }
    }
}
