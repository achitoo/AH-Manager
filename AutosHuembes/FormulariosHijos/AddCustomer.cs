using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutosHuembes.FormulariosHijos
{
    public partial class AddCustomer : Form
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDNI.Text) ||
                string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbNumber.Text) ||
                string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cedula = tbDNI.Text;
            Nombre = tbName.Text + " " + tbLastName.Text; // Concatenar aquí
            Correo = tbEmail.Text;
            Contacto = tbNumber.Text;
            Direccion = tbAddress.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cerrar sin guardar
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cerrar sin guardar
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
