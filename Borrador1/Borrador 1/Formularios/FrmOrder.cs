using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Borrador_1.Modelos;

namespace Borrador_1.Formularios
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();

        }
        private List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        private void btnBackOrderFrmToMain_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Crear una instancia de Vehiculo
            Vehiculo vehiculo = new Vehiculo(
                tbBrand.Text,
                tbModel.Text,
                tbDetails.Text,
                tbYear.Text,
                tbMontoTotal.Text
            );

            // Configurar las columnas del DataGridView
            dgbOrder.Columns.Add("Marca", "Marca");
            dgbOrder.Columns.Add("Modelo", "Modelo");
            dgbOrder.Columns.Add("Detalles", "Detalles");
            dgbOrder.Columns.Add("Año", "Año");
            dgbOrder.Columns.Add("MontoTotal", "Monto Total");

            // Añadir los datos al DataGridView
            dgbOrder.Rows.Add(vehiculo.Marca, vehiculo.Modelo, vehiculo.Detalles, vehiculo.Año, vehiculo.MontoTotal);

            // Guardar los datos en la lista
            listaVehiculos.Add(vehiculo);
            Clear();

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            int indiceFilaSeleccionada = 0;

            if (indiceFilaSeleccionada >= 0)
            {

                // Actualizar los datos en el DataGridView
                dgbOrder.Rows[indiceFilaSeleccionada].Cells[0].Value = tbBrand.Text;
                dgbOrder.Rows[indiceFilaSeleccionada].Cells[1].Value = tbModel.Text;
                dgbOrder.Rows[indiceFilaSeleccionada].Cells[2].Value = tbDetails.Text;
                dgbOrder.Rows[indiceFilaSeleccionada].Cells[3].Value = tbYear.Text;
                dgbOrder.Rows[indiceFilaSeleccionada].Cells[4].Value = tbMontoTotal.Text;

                // Actualizar el objeto en la lista
                Vehiculo vehiculo = listaVehiculos[indiceFilaSeleccionada];
                vehiculo.Marca = tbBrand.Text;
                vehiculo.Modelo = tbModel.Text;
                vehiculo.Detalles = tbDetails.Text;
                vehiculo.Año = tbYear.Text;
                vehiculo.MontoTotal = tbMontoTotal.Text;
                Clear();
            }

        }

        public void Clear()
        {
            // Limpiar los text boxes
            tbBrand.Clear();
            tbModel.Clear();
            tbDetails.Clear();
            tbYear.Clear();
            tbMontoTotal.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indiceFilaSeleccionada = 0;
            if (indiceFilaSeleccionada >= 0)
            {
                // Eliminar la fila seleccionada del DataGridView
                dgbOrder.Rows.RemoveAt(indiceFilaSeleccionada);

                // Eliminar el objeto de la lista
                listaVehiculos.RemoveAt(indiceFilaSeleccionada);



                indiceFilaSeleccionada = -1;
            }
        }
    }
}
