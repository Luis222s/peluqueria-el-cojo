using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using peluqueria_el_cojo.Modelos;
using peluqueria_el_cojo.Utilidades;
using Microsoft.Data.SqlClient;

namespace peluqueria_el_cojo.Servicios
{
    public class AuthService
    {
        public static Usuario Login(string username, string password)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT * FROM Usuarios WHERE Username=@user AND Password=@pass";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Usuario(
                        reader["Username"].ToString(),
                        reader["Password"].ToString(),
                        (Rol)Enum.Parse(typeof(Rol), reader["Rol"].ToString())
                    );
                }

                return null;
            }
        }
        public static bool Registrar(string username, string password, Rol rol)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "INSERT INTO Usuarios (Username, Password, Rol) VALUES (@user, @pass, @rol)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@rol", rol.ToString());

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
