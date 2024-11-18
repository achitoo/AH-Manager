using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador_1.Formularios
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void btnBackOrderFrmToMain_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Hide();
        }
    }
}
