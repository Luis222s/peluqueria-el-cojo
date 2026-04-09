using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Utilidades
{
    public class GeneradorReportes
    {
        public static string GenerarReporte<T>(List<T> datos)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("=== REPORTE ===");
            sb.AppendLine($"Tipo: {typeof(T).Name}");
            sb.AppendLine("----------------------");

            foreach (var item in datos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
