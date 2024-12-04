using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AutosHuembes.Modelos
{
    public class CustomerManager
    {
        public List<Cliente> ListaClientes { get; private set; }

        public CustomerManager()
        {
            ListaClientes = new List<Cliente>();
            EnsureFileExists("customer.txt"); // Verifica y crea el archivo al inicializar la clase
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
            ListaClientes.Clear(); // Limpiar la lista antes de cargar

            if (File.Exists(rutaArchivo))
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        if (datos.Length == 5) // Verificar que tenga 5 campos
                        {
                            ListaClientes.Add(new Cliente(
                                datos[0], // Cedula
                                datos[1], // Nombre
                                datos[2], // Correo
                                datos[3], // Contacto
                                datos[4]  // Dirección
                            ));
                        }
                        else
                        {
                            MessageBox.Show($"Formato incorrecto en línea: {linea}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    sw.WriteLine($"{cliente.Cedula},{cliente.Nombre},{cliente.Correo},{cliente.Contacto},{cliente.Direccion}");
                }
            }
        }

        private void EnsureFileExists(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
            {
                // Crear un archivo vacío si no existe
                using (File.Create(rutaArchivo)) { }
            }
        }
    }
}
