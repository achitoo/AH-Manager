using System;

namespace AutosHuembes.Modelos
{
    public class Usuarios
    {
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Administrador { get; set; }

        public Usuarios(string nombre, string usuario, string correo, string contraseña, string administrador)
        {
            Nombre = nombre;
            Usuario = usuario;
            Correo = correo;
            Contraseña = contraseña;
            Administrador = administrador;
        }
    }
}
