using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador_1.Funciones
{
    internal class Validate
    {
        public bool Validar(string user, string password)
        {
            // Aquí se verifica el usuario y la contraseña
            if (user == "admin" && password == "123")
            {
                MessageBox.Show("Bienvenido " + user);
                return true;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return false;
            }
        }
    }
}
