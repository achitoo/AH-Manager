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
using AutosHuembes.Formularios;
using AutosHuembes.Modelos;

namespace AutosHuembes
{
    public partial class FrmInicio : Form
    {
        public string UsuarioActual { get; set; }
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null, e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Order());
        }

        private void BTNventas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Order());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Customer());
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            // Abrir FrmLogin
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                // Cargar los usuarios desde el archivo (usando UserController o similar)
                var usuarios = new UserController();
                usuarios.LoadUsers("users.txt");

                // Buscar el usuario actual en la lista
                var usuarioLogueado = usuarios.ObtainUser()
                    .FirstOrDefault(u => u.Usuario == UsuarioActual || u.Correo == UsuarioActual);

                if (usuarioLogueado != null && usuarioLogueado.Administrador == "Autorizado")
                {
                    // Usuario tiene permisos de administrador, abrir el formulario Users
                    AbrirFormEnPanel(new Users());
                }
                else
                {
                    // Usuario no tiene permisos
                    MessageBox.Show("No tienes permisos para acceder a la administración de usuarios.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar permisos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
