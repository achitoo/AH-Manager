using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutosHuembes.FormulariosHijos
{
    public partial class EditOrder : Form
    {
        public string Comprador { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public string Monto { get; set; }
        public string Detalles { get; set; }
        public EditOrder()
        {
            InitializeComponent();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            // Precargar los datos en los campos de texto
            tbName.Text = Comprador;
            tbBrand.Text = Marca;
            tbModel.Text = Modelo;
            cmbYear.Text = Año;
            tbPrice.Text = Monto;
            tbDetails.Text = Detalles;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validar los campos
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

            // Cerrar el formulario con resultado OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
