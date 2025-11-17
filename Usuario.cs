using System;

namespace TiendadeCalzados.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string User { get; set; } 
        public string Clave { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public Rol Rol { get; set; }
        public int Estado { get; set; }


        //  public int IdRol { get; set; }

    }
}
