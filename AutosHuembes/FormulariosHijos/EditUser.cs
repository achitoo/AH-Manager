using System;
using System.Windows.Forms;
using AutosHuembes.Modelos;

namespace AutosHuembes.FormulariosHijos
{
    public partial class EditUser : Form
    {
        private Usuarios currentUser;

        public EditUser(Usuarios user)
        {
            InitializeComponent();
            currentUser = user;
            LoadUserData();
        }

        private void LoadUserData()
        {
            tbName.Text = currentUser.Nombre;
            tbUsername.Text = currentUser.Usuario;
            tbEmail.Text = currentUser.Correo;
            tbPassword.Text = currentUser.Contraseña;
            cmbAdmin.Text = currentUser.Administrador;
        }

        public Usuarios GetUser()
        {
            return new Usuarios(
                tbName.Text,
                tbUsername.Text,
                tbEmail.Text,
                tbPassword.Text,
                cmbAdmin.Text
            );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
