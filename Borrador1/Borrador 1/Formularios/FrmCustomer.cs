using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Borrador_1.Funciones;
using Borrador_1.Modelos;

namespace Borrador_1.Formularios
{
    public partial class FrmCustomer : Form
    {
        private CustomerManager customerManager = new CustomerManager();
        private int indiceFilaSeleccionada = -1;
        public FrmCustomer()
        {
            InitializeComponent();

            dgbCustomers.AutoGenerateColumns = false;
            dgbCustomers.Columns.Add("Cedula", "Cédula");
            dgbCustomers.Columns.Add("Nombre", "Nombre");
            dgbCustomers.Columns.Add("Direccion", "Dirección");
            dgbCustomers.Columns.Add("Contacto", "Contacto");
            dgbCustomers.Columns.Add("Correo", "Correo");

            CargarRegistros();
        }

        private void btnCloseFrm_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.Show();
        }

        private void CargarRegistros()
        {
            string rutaArchivo = "clientes.txt";
            if (File.Exists(rutaArchivo))
            {
                customerManager.CargarDesdeArchivo(rutaArchivo);
                ActualizarGrid();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente(
                tbDNI.Text,
                tbName.Text,
                tbAddress.Text,
                tbNumber.Text,
                tbEmail.Text
            );

            if (indiceFilaSeleccionada >= 0)
            {
                customerManager.EditarCliente(indiceFilaSeleccionada, cliente);
                ActualizarGrid();
                indiceFilaSeleccionada = -1;
            }
            else
            {
                customerManager.AgregarCliente(cliente);
                dgbCustomers.Rows.Add(cliente.Cedula, cliente.Nombre, cliente.Direccion, cliente.Contacto, cliente.Correo);
            }

            LimpiarCampos();
            GuardarRegistros();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (indiceFilaSeleccionada >= 0)
            {
                var cliente = new Cliente(
                    tbDNI.Text,
                    tbName.Text,
                    tbAddress.Text,
                    tbNumber.Text,
                    tbEmail.Text
                );

                customerManager.EditarCliente(indiceFilaSeleccionada, cliente);
                ActualizarGrid();
                LimpiarCampos();
                indiceFilaSeleccionada = -1;
                GuardarRegistros();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (indiceFilaSeleccionada >= 0)
            {
                customerManager.EliminarCliente(indiceFilaSeleccionada);
                ActualizarGrid();
                LimpiarCampos();
                indiceFilaSeleccionada = -1;
                GuardarRegistros();
            }
        }
        private void dgbCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indiceFilaSeleccionada = e.RowIndex;
                var row = dgbCustomers.Rows[e.RowIndex];
                tbDNI.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbAddress.Text = row.Cells[2].Value.ToString();
                tbNumber.Text = row.Cells[3].Value.ToString();
                tbEmail.Text = row.Cells[4].Value.ToString();
            }
        }

        private void ActualizarGrid()
        {
            dgbCustomers.Rows.Clear();
            foreach (var cliente in customerManager.ListaClientes)
            {
                dgbCustomers.Rows.Add(cliente.Cedula, cliente.Nombre, cliente.Direccion, cliente.Contacto, cliente.Correo);
            }
        }

        private void LimpiarCampos()
        {
            tbDNI.Clear();
            tbName.Clear();
            tbAddress.Clear();
            tbNumber.Clear();
            tbEmail.Clear();
        }

        private void GuardarRegistros()
        {
            customerManager.GuardarEnArchivo("clientes.txt");
        }
    }
}
