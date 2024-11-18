using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Borrador_1.Modelos;

namespace Borrador_1.Formularios
{
    public partial class FrmOrder : Form
    {
        public List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        private int indiceFilaSeleccionada = -1;

        public FrmOrder()
        {
            InitializeComponent();
            // Desactivar AutoGenerateColumns
            dgbOrder.AutoGenerateColumns = false;

            // Configurar las columnas del DataGridView
            dgbOrder.Columns.Add("Marca", "Marca");
            dgbOrder.Columns.Add("Modelo", "Modelo");
            dgbOrder.Columns.Add("Detalles", "Detalles");
            dgbOrder.Columns.Add("Año", "Año");
            dgbOrder.Columns.Add("MontoTotal", "Monto Total");
        }

        private void btnBackOrderFrmToMain_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

                indiceFilaSeleccionada = -1; // Resetear el índice después de editar
            }
            else
            {
                // Crear una instancia de Vehiculo
                Vehiculo vehiculo = new Vehiculo(
                    tbBrand.Text,
                    tbModel.Text,
                    tbDetails.Text,
                    tbYear.Text,
                    tbMontoTotal.Text
                );

                // Añadir los datos al DataGridView
                dgbOrder.Rows.Add(vehiculo.Marca, vehiculo.Modelo, vehiculo.Detalles, vehiculo.Año, vehiculo.MontoTotal);

                // Guardar los datos en la lista
                listaVehiculos.Add(vehiculo);
            }

            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
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
                indiceFilaSeleccionada = -1;
            }
        }

        private void dgbOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgbOrder.Rows[e.RowIndex];
                tbBrand.Text = row.Cells[0].Value.ToString();
                tbModel.Text = row.Cells[1].Value.ToString();
                tbDetails.Text = row.Cells[2].Value.ToString();
                tbYear.Text = row.Cells[3].Value.ToString();
                tbMontoTotal.Text = row.Cells[4].Value.ToString();

                indiceFilaSeleccionada = e.RowIndex;
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
            if (indiceFilaSeleccionada >= 0)
            {
                // Eliminar la fila seleccionada del DataGridView
                dgbOrder.Rows.RemoveAt(indiceFilaSeleccionada);

                // Eliminar el objeto de la lista
                listaVehiculos.RemoveAt(indiceFilaSeleccionada);

                Clear();
                indiceFilaSeleccionada = -1;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("vehiculos.txt"))
            {
                foreach (Vehiculo vehiculo in listaVehiculos)
                {
                    sw.WriteLine($"{vehiculo.Marca},{vehiculo.Modelo},{vehiculo.Detalles},{vehiculo.Año},{vehiculo.MontoTotal}");
                }
            }
            MessageBox.Show("Datos guardados en vehiculos.txt");
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            listaVehiculos.Clear();
            dgbOrder.Rows.Clear();

            using (StreamReader sr = new StreamReader("vehiculos.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] datos = line.Split(',');
                    Vehiculo vehiculo = new Vehiculo(datos[0], datos[1], datos[2], datos[3], datos[4]);
                    listaVehiculos.Add(vehiculo);
                    dgbOrder.Rows.Add(vehiculo.Marca, vehiculo.Modelo, vehiculo.Detalles, vehiculo.Año, vehiculo.MontoTotal);
                }
            }
            MessageBox.Show("Datos cargados desde vehiculos.txt");
        }
    }
}
