using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;

namespace peluqueria_el_cojo.Utilidades
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection("Server=.;Database=PeluqueriaDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
