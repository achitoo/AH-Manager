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
    public partial class FrmSearch : Form
    {
        private List<Vehiculo> listaVehiculos;

        public FrmSearch(List<Vehiculo> vehiculos)
        {

            InitializeComponent();
            listaVehiculos = vehiculos ?? new List<Vehiculo>();

            // Desactivar AutoGenerateColumns
            dgvResult.AutoGenerateColumns = false;

            // Configurar las columnas del DataGridView
            dgvResult.Columns.Add("Marca", "Marca");
            dgvResult.Columns.Add("Modelo", "Modelo");
            dgvResult.Columns.Add("Detalles", "Detalles");
            dgvResult.Columns.Add("Año", "Año");
            dgvResult.Columns.Add("MontoTotal", "Monto Total");

        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string criterio = tbSearch.Text;
            FiltrarDatos(criterio);
        }

        private void FiltrarDatos(string criterio)
        {
            dgvResult.Rows.Clear();

            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                if (vehiculo.Marca.Contains(criterio) ||
                    vehiculo.Modelo.Contains(criterio) ||
                    vehiculo.Detalles.Contains(criterio) ||
                    vehiculo.Año.Contains(criterio) ||
                    vehiculo.MontoTotal.Contains(criterio))
                {
                    dgvResult.Rows.Add(vehiculo.Marca, vehiculo.Modelo, vehiculo.Detalles, vehiculo.Año, vehiculo.MontoTotal);
                }
            }
        }
    }
}


