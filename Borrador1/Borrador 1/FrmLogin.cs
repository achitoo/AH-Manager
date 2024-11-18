using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Borrador_1.Formularios;
using Borrador_1.Funciones;

namespace Borrador_1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Validate validator = new Validate();
            string user = tbUser.Text;
            string password = tbPassword.Text;

            bool isValid = validator.Validar(user, password);

            if (isValid)
            {
                FrmMain frm = new FrmMain();
                frm.Show();
                this.Hide();
            }
        }
    }
}
