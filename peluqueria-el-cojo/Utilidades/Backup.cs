using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Utilidades
{
    public class Backup
    {
        public static void Guardar(string contenido)
        {
            string ruta = "backup.txt";
            File.WriteAllText(ruta, contenido);
        }
    }
}
