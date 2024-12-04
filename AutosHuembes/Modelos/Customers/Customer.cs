using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosHuembes.Modelos
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }

        public Cliente(string cedula, string nombre, string correo, string contacto, string direccion)
        {
            Cedula = cedula;
            Nombre = nombre;
            Contacto = contacto;
            Correo = correo;
            Direccion = direccion;
        }
    }
}
