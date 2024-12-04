using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AutosHuembes.Modelos;
using Microsoft.VisualBasic.ApplicationServices;

namespace AutosHuembes
{
    public partial class FrmLogin : Form
    {
        private UserController userController;
        public FrmLogin()
        {
            InitializeComponent();
            userController = new UserController();
            string rutaArchivoUsuarios = "users.txt";
            userController.LoadUsers(rutaArchivoUsuarios); // Cargar usuarios desde el archivo
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Placeholder or WaterMark
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == "Usuario")
            {
                tbUser.Text = "";
                tbUser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
            {
                tbUser.Text = "Usuario";
                tbUser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == "Contraseña")
            {
                tbPass.Text = "";
                tbPass.ForeColor = Color.LightGray;
                tbPass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.Text = "Contraseña";
                tbPass.ForeColor = Color.Silver;
                tbPass.UseSystemPasswordChar = false;
            }
        }

        #endregion 

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string input = tbUser.Text.Trim(); // Usuario o correo
            string password = tbPass.Text;

            // Declara una variable para el usuario logueado
            if (ValidateUser(input, password, out Usuarios loggedUser))
            {
                FrmInicio frmInicio = new FrmInicio
                {
                    UsuarioActual = loggedUser.Usuario // Establece el usuario actual
                };
                frmInicio.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario/Correo o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUser(string input, string password, out Usuarios loggedUser)
        {
            var users = userController.ObtainUser();

            // Busca el usuario que coincide con el nombre de usuario/correo y la contraseña
            loggedUser = users.FirstOrDefault(user =>
                (user.Usuario == input || user.Correo == input) && user.Contraseña == password);

            return loggedUser != null; // Devuelve true si encuentra un usuario válido
        }

    }
}
