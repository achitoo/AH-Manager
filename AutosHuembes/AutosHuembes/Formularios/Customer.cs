using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using AutosHuembes.Modelos;
using System.Windows.Forms;
using AutosHuembes.Formularios;
using AutosHuembes.FormulariosHijos;

namespace AutosHuembes.Formularios
{
    public partial class Customer : Form
    {
        private CustomerController customerController;
        private Cliente clienteSeleccionado; // Variable para almacenar el cliente seleccionado

        public Customer()
        {
            InitializeComponent();
            customerController = new CustomerController();

            // Configurar DataGridView al inicializar
            ConfigurarDataGridView();

            // Asegurarse de que las columnas no se generen automáticamente
            dgbCustomer.AutoGenerateColumns = false;

            // Asociar el evento CellClick
            dgbCustomer.CellClick += dgbCustomers_CellClick;

            // Asegurar la carga de clientes al inicializar el formulario
            this.Load += cliente_Load; // Vincular el evento Load
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer();

            if (addCustomerForm.ShowDialog() == DialogResult.OK)
            {
                customerController.AgregarCliente(
                    addCustomerForm.Cedula,
                    addCustomerForm.Nombre,
                    addCustomerForm.Correo,
                    addCustomerForm.Contacto,
                    addCustomerForm.Direccion
                );

                ActualizarListaClientes();
            }
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customer.txt");
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show($"El archivo {rutaArchivo} no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            customerController.CargarClientes(rutaArchivo);
            ActualizarListaClientes();
        }

        private void ConfigurarDataGridView()
        {
            dgbCustomer.Columns.Clear();

            // Configurar columnas
            dgbCustomer.Columns.Add("Cedula", "Cédula");
            dgbCustomer.Columns.Add("Nombre", "Nombre");
            dgbCustomer.Columns.Add("Correo", "Correo");
            dgbCustomer.Columns.Add("Contacto", "Contacto");
            dgbCustomer.Columns.Add("Direccion", "Dirección");
        }

        private void ActualizarListaClientes()
        {
            // Validar si las columnas están configuradas
            if (dgbCustomer.Columns.Count == 0)
            {
                ConfigurarDataGridView();
            }

            dgbCustomer.Rows.Clear(); // Limpiar filas

            foreach (var cliente in customerController.ObtenerClientes())
            {
                dgbCustomer.Rows.Add(
                    cliente.Cedula,
                    cliente.Nombre,
                    cliente.Correo,
                    cliente.Contacto,
                    cliente.Direccion
                );
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgbCustomer.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la fila seleccionada
            string cedulaSeleccionada = dgbCustomer.CurrentRow.Cells["Cedula"].Value.ToString();
            var clienteSeleccionado = customerController.ObtenerClientes().FirstOrDefault(c => c.Cedula == cedulaSeleccionada);

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el formulario hijo y pasar los datos
            EditCustomer editCustomerForm = new EditCustomer
            {
                Cedula = clienteSeleccionado.Cedula,
                Nombre = clienteSeleccionado.Nombre,
                Correo = clienteSeleccionado.Correo,
                Contacto = clienteSeleccionado.Contacto,
                Direccion = clienteSeleccionado.Direccion
            };

            // Mostrar formulario hijo
            if (editCustomerForm.ShowDialog() == DialogResult.OK)
            {
                // Actualizar datos del cliente en el controlador
                clienteSeleccionado.Cedula = editCustomerForm.Cedula;
                clienteSeleccionado.Nombre = editCustomerForm.Nombre;
                clienteSeleccionado.Correo = editCustomerForm.Correo;
                clienteSeleccionado.Contacto = editCustomerForm.Contacto;
                clienteSeleccionado.Direccion = editCustomerForm.Direccion;


                // Actualizar la lista en el DataGridView
                ActualizarListaClientes();
            }
        }

        private void dgbCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que se haga clic en una fila válida
            if (e.RowIndex >= 0)
            {
                var row = dgbCustomer.Rows[e.RowIndex];

                // Crear un cliente con los datos de la fila seleccionada
                clienteSeleccionado = new Cliente(
                    row.Cells["Cedula"].Value?.ToString(),
                    row.Cells["Nombre"].Value?.ToString(),
                    row.Cells["Direccion"].Value?.ToString(),
                    row.Cells["Contacto"].Value?.ToString(),
                    row.Cells["Correo"].Value?.ToString()
                );
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            ActualizarListaClientes();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgbCustomer.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar la acción de eliminar
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmación",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Obtener el índice de la fila seleccionada
                int indiceSeleccionado = dgbCustomer.CurrentRow.Index;

                // Eliminar cliente del controlador
                customerController.EliminarCliente(indiceSeleccionado);

                // Actualizar la lista de clientes en el DataGridView
                ActualizarListaClientes();
            }
        }

    }
}
