using System;
using System.Windows.Forms;
using AutosHuembes.Modelos;

namespace AutosHuembes.FormulariosHijos
{
    public partial class AddUser : Form
    {
        public Usuarios NewUser { get; private set; }

        public AddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(tbName.Text) ||
                    string.IsNullOrWhiteSpace(tbUsername.Text) ||
                    string.IsNullOrWhiteSpace(tbEmail.Text) ||
                    string.IsNullOrWhiteSpace(tbPassword.Text) ||
                    string.IsNullOrWhiteSpace(tbConfirmpassword.Text) ||
                    string.IsNullOrWhiteSpace(cmbAdmin.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que las contraseñas coincidan
                if (tbPassword.Text != tbConfirmpassword.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear un nuevo usuario
                NewUser = new Usuarios(
                    tbName.Text,
                    tbUsername.Text,
                    tbEmail.Text,
                    tbPassword.Text,
                    cmbAdmin.Text
                );

                // Indicar que el formulario fue completado exitosamente
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario sin guardar
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
