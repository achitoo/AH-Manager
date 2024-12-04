using System;
using System.Windows.Forms;

namespace AutosHuembes.FormulariosHijos
{
    public partial class EditCustomer : Form
    {
        // Propiedades públicas para recibir y devolver los datos del cliente
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public string Correo { get; set; }

        public EditCustomer()
        {
            InitializeComponent();
        }

        // Evento Load para precargar los datos en los campos del formulario
        private void EditCustomer_Load(object sender, EventArgs e)
        {
            // Precargar los datos en los campos de texto
            tbDNI.Text = Cedula;
            tbName.Text = ObtenerPrimerNombre(Nombre); // Primer nombre
            tbLastName.Text = ObtenerApellido(Nombre); // Apellido (si existe)
            tbAddress.Text = Direccion;
            tbNumber.Text = Contacto;
            tbEmail.Text = Correo;
        }

        private string ObtenerPrimerNombre(string nombreCompleto)
        {
            return nombreCompleto.Split(' ')[0]; // Retorna el primer nombre
        }

        private string ObtenerApellido(string nombreCompleto)
        {
            var partes = nombreCompleto.Split(' ');
            return partes.Length > 1 ? partes[1] : ""; // Retorna el apellido, si existe
        }

        // Botón para cancelar y cerrar sin guardar cambios
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Validar los campos
            if (string.IsNullOrWhiteSpace(tbDNI.Text) ||
                string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text) ||
                string.IsNullOrWhiteSpace(tbAddress.Text) ||
                string.IsNullOrWhiteSpace(tbNumber.Text) ||
                string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar las propiedades con los valores editados
            Cedula = tbDNI.Text;
            Nombre = $"{tbName.Text} {tbLastName.Text}";
            Direccion = tbAddress.Text;
            Contacto = tbNumber.Text;
            Correo = tbEmail.Text;

            // Cerrar el formulario con resultado OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
