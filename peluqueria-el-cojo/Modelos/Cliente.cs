using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Modelos
{
    using System;

    namespace PeluqueriaElCojo.Modelos
    {
        public class Cliente
        {
            private string nombre;
            private string telefono;
            private TipoCliente tipo;
            private int visitas;

            public string Nombre
            {
                get { return nombre; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El nombre no puede estar vacío");

                    nombre = value;
                }
            }

            public string Telefono
            {
                get { return telefono; }
                set
                {
                    if (value.Length != 10)
                        throw new ArgumentException("El teléfono debe tener 10 dígitos");

                    telefono = value;
                }
            }

            public TipoCliente Tipo
            {
                get { return tipo; }
                set { tipo = value; }
            }

            public int Visitas
            {
                get { return visitas; }
                private set { visitas = value; }
            }

            public Cliente(string nombre, string telefono, TipoCliente tipo)
            {
                Nombre = nombre;
                Telefono = telefono;
                Tipo = tipo;
                Visitas = 0;
            }

            public void RegistrarVisita()
            {
                Visitas++;
            }

            public double ObtenerDescuento()
            {
                switch (Tipo)
                {
                    case TipoCliente.Nuevo:
                        return 0;
                    case TipoCliente.Regular:
                        return 0.05;
                    case TipoCliente.VIP:
                        return 0.10; 
                    default:
                        return 0;
                }
            }

            public bool Coincide(string criterio)
            {
                return Nombre.Contains(criterio) || Telefono.Contains(criterio);
            }
        }
    }
}
