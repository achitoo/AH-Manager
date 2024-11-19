using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador_1.Modelos
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public string Correo { get; set; }

        public Cliente(string cedula, string nombre, string direccion, string contacto, string correo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Direccion = direccion;
            Contacto = contacto;
            Correo = correo;
        }
    }
}
