using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Borrador_1.Funciones;
using Borrador_1.Modelos;
using System.Xml.Linq;

namespace Borrador_1.Formularios
{
    public partial class FrmOrder : Form
    {
        private VehicleManager vehicleManager = new VehicleManager();
        private int indiceFilaSeleccionada = -1;

        public FrmOrder()
        {
            InitializeComponent();
            LoadVehicles();
            // Desactivar AutoGenerateColumns
            dgbOrder.AutoGenerateColumns = false;

            // Configurar las columnas del DataGridView
            dgbOrder.Columns.Add("Marca", "Marca");
            dgbOrder.Columns.Add("Modelo", "Modelo");
            dgbOrder.Columns.Add("Detalles", "Detalles");
            dgbOrder.Columns.Add("Año", "Año");
            dgbOrder.Columns.Add("MontoTotal", "Monto Total");
        }

        private void LoadVehicles()
        {
            string rutaArchivo = "vehiculos.txt";
            if (File.Exists(rutaArchivo))
            {
                vehicleManager.LoadFromFile(rutaArchivo);
                UpdateGrid();
            }
        }

        private void btnBackOrderFrmToMain_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var vehicle = new Vehicle(
                tbBrand.Text,
                tbModel.Text,
                tbDetails.Text,
                tbYear.Text,
                tbMontoTotal.Text
            );

            if (indiceFilaSeleccionada >= 0)
            {
                vehicleManager.EditVehicle(indiceFilaSeleccionada, vehicle);
                UpdateGrid();
                indiceFilaSeleccionada = -1;
            }
            else
            {
                vehicleManager.AddVehicle(vehicle);
                dgbOrder.Rows.Add(vehicle.Marca, vehicle.Modelo, vehicle.Detalles, vehicle.Año, vehicle.MontoTotal);
            }

            LimpiarCampos();
            SaveVehicles();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (indiceFilaSeleccionada >= 0)
            {
                var vehicle = new Vehicle(
                    tbBrand.Text,
                    tbModel.Text,
                    tbDetails.Text,
                    tbYear.Text,
                    tbMontoTotal.Text
                );

                vehicleManager.EditVehicle(indiceFilaSeleccionada, vehicle);
                UpdateGrid();
                LimpiarCampos();
                indiceFilaSeleccionada = -1;
                SaveVehicles();
            }
        }

        private void dgbOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indiceFilaSeleccionada = e.RowIndex;
                var row = dgbOrder.Rows[e.RowIndex];
                tbBrand.Text = row.Cells[0].Value.ToString();
                tbModel.Text = row.Cells[1].Value.ToString();
                tbDetails.Text = row.Cells[2].Value.ToString();
                tbYear.Text = row.Cells[3].Value.ToString();
                tbMontoTotal.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (indiceFilaSeleccionada >= 0)
            {
                vehicleManager.DeleteVehicle(indiceFilaSeleccionada);
                UpdateGrid();
                LimpiarCampos();
                indiceFilaSeleccionada = -1;
                SaveVehicles();
            }
        }

        private void UpdateGrid()
        {
            dgbOrder.Rows.Clear();
            foreach (var vehicle in vehicleManager.VehicleList)
            {
                dgbOrder.Rows.Add(vehicle.Marca, vehicle.Modelo, vehicle.Detalles, vehicle.Año, vehicle.MontoTotal);
            }
        }
        private void LimpiarCampos()
        {
            tbBrand.Clear();
            tbModel.Clear();
            tbDetails.Clear();
            tbYear.Clear();
            tbMontoTotal.Clear();
        }

        private void SaveVehicles()
        {
            vehicleManager.SaveInFile("vehiculos.txt");
        }
    }
}
