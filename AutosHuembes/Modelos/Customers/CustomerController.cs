using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutosHuembes.Modelos
{
    public class CustomerController
    {
        private CustomerManager customerManager;

        public CustomerController()
        {
            customerManager = new CustomerManager();
        }

        public List<Cliente> ObtenerClientes()
        {
            return customerManager.ListaClientes;
        }

        public void GuardarCambios()
        {
            string rutaArchivo = "customer.txt";
            customerManager.GuardarEnArchivo(rutaArchivo);
        }

        public void AgregarCliente(string cedula, string nombre, string correo, string contacto, string direccion)
        {
            var cliente = new Cliente(cedula, nombre, correo, contacto, direccion);
            customerManager.AgregarCliente(cliente);
            GuardarCambios();
        }

        public void EditarCliente(int indice, Cliente cliente)
        {
            customerManager.EditarCliente(indice, cliente);
            GuardarCambios();
        }

        public void EliminarCliente(int indice)
        {
            customerManager.EliminarCliente(indice);
            GuardarCambios();
        }

        public void CargarClientes(string rutaArchivo)
        {
            customerManager.CargarDesdeArchivo(rutaArchivo);
        }
    }
}
