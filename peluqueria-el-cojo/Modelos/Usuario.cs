using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Modelos
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Rol Rol { get; set; }

        public Usuario(string username, string password, Rol rol)
        {
            Username = username;
            Password = password;
            Rol = rol;
        }
    }
}
