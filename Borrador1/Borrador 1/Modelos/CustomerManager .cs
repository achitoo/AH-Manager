using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Borrador_1.Modelos;
using System.Windows.Forms;
using System.IO;

namespace Borrador_1.Funciones
{
    public class CustomerManager
    {
        public List<Cliente> ListaClientes { get; private set; }

        public CustomerManager()
        {
            ListaClientes = new List<Cliente>();
        }

        public void AgregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }

        public void EditarCliente(int indice, Cliente cliente)
        {
            if (indice >= 0 && indice < ListaClientes.Count)
            {
                ListaClientes[indice] = cliente;
            }
        }

        public void EliminarCliente(int indice)
        {
            if (indice >= 0 && indice < ListaClientes.Count)
            {
                ListaClientes.RemoveAt(indice);
            }
        }

        public void CargarDesdeArchivo(string rutaArchivo)
        {
            ListaClientes.Clear();
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        if (datos.Length == 5)
                        {
                            ListaClientes.Add(new Cliente(
                                datos[0], datos[1], datos[2], datos[3], datos[4]
                            ));
                        }
                    }
                }
            }
        }

        public void GuardarEnArchivo(string rutaArchivo)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (var cliente in ListaClientes)
                {
                    sw.WriteLine($"{cliente.Cedula},{cliente.Nombre},{cliente.Direccion},{cliente.Contacto},{cliente.Correo}");
                }
            }
        }
    }
}
