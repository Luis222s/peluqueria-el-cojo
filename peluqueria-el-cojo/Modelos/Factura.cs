using peluqueria_el_cojo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Modelos
{
    public class Factura
    {
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public List<Servicio> Servicios { get; set; }

        public Factura(Cliente cliente, Empleado empleado)
        {
            Cliente = cliente;
            Empleado = empleado;
            Servicios = new List<Servicio>();
        }
        public void AgregarServicio(Servicio servicio)
        {
            Servicios.Add(servicio);
        }

        public double CalcularSubtotal()
        {
            double total = 0;

            foreach (var s in Servicios)
            {
                total += s.CalcularPrecio();
            }

            return total;
        }

        public double CalcularDescuento()
        {
            return CalcularSubtotal() * Cliente.ObtenerDescuento();
        }

        public double CalcularITBIS()
        {
            return (CalcularSubtotal() - CalcularDescuento()) * 0.18;
        }

        public double CalcularTotal()
        {
            return CalcularSubtotal() - CalcularDescuento() + CalcularITBIS();
        }

        public string GenerarRecibo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("=== FACTURA ===");
            sb.AppendLine($"Cliente: {Cliente.Nombre}");
            sb.AppendLine($"Barbero: {Empleado.Nombre}");
            sb.AppendLine("----------------------");

            foreach (var s in Servicios)
            {
                sb.AppendLine(s.GenerarLineaRecibo());
            }

            sb.AppendLine("----------------------");
            sb.AppendLine($"Subtotal: RD${CalcularSubtotal()}");
            sb.AppendLine($"Descuento: RD${CalcularDescuento()}");
            sb.AppendLine($"ITBIS (18%): RD${CalcularITBIS()}");
            sb.AppendLine($"TOTAL: RD${CalcularTotal()}");

            return sb.ToString();
        }
        public void RegistrarVenta()
        {
            Empleado.RegistrarVenta(CalcularTotal());
        }
    }
}
