using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutosHuembes.FormulariosHijos
{
    public partial class AddOrder : Form
    {
        public string Comprador { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public string Monto { get; set; }
        public string Detalles { get; set; }
        public AddOrder()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) ||
            string.IsNullOrWhiteSpace(tbBrand.Text) ||
            string.IsNullOrWhiteSpace(tbModel.Text) ||
            string.IsNullOrWhiteSpace(cmbYear.Text) ||
            string.IsNullOrWhiteSpace(tbPrice.Text) ||
            string.IsNullOrWhiteSpace(tbDetails.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Comprador = tbName.Text;
            Marca = tbBrand.Text;
            Modelo = tbModel.Text;
            Año = cmbYear.Text;
            Monto = tbPrice.Text;
            Detalles = tbDetails.Text;

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
    }
}
