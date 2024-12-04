using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutosHuembes.FormulariosHijos;
using AutosHuembes.Modelos;

namespace AutosHuembes.Formularios
{
    public partial class Order : Form
    {
        private OrderController orderController;
        private Orden compradorSeleccionado; // Variable para almacenar la orden seleccionada
        public Order()
        {
            InitializeComponent();
            orderController = new OrderController();

            // Configurar DataGridView al inicializar
            ConfigDataGridView();

            // Asegurarse de que las columnas no se generen automáticamente
            dgbOrders.AutoGenerateColumns = false;

            // Asociar el evento CellClick
            dgbOrders.CellClick += dgbOrders_CellClick;

            // Asegurar la carga de ordenes al inicializar el formulario
            this.Load += order_Load; // Vincular el evento Load
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder addOrderForm = new AddOrder();

            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                orderController.AddOrder(
                    addOrderForm.Comprador,
                    addOrderForm.Marca,
                    addOrderForm.Modelo,
                    addOrderForm.Año,
                    addOrderForm.Monto,
                    addOrderForm.Detalles
                );

                UpdateOrderList();
            }
        }
        private void order_Load(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "order.txt");
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show($"El archivo {rutaArchivo} no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            orderController.LoadOrders(rutaArchivo);
            UpdateOrderList();
        }

        private void ConfigDataGridView()
        {
            dgbOrders.Columns.Clear();

            // Configurar columnas
            dgbOrders.Columns.Add("Comprador", "Comprador");
            dgbOrders.Columns.Add("Marca", "Marca");
            dgbOrders.Columns.Add("Modelo", "Modelo");
            dgbOrders.Columns.Add("Año", "Año");
            dgbOrders.Columns.Add("Monto", "Monto");
            dgbOrders.Columns.Add("Detalles", "Detalles");
        }

        private void UpdateOrderList()
        {
            // Validar si las columnas están configuradas
            if (dgbOrders.Columns.Count == 0)
            {
                ConfigDataGridView();
            }

            dgbOrders.Rows.Clear(); // Limpiar filas

            foreach (var orden in orderController.ObtainOrder())
            {
                dgbOrders.Rows.Add(
                    orden.Comprador,
                    orden.Marca,
                    orden.Modelo,
                    orden.Año,
                    orden.Monto,
                    orden.Detalles
                );
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dgbOrders.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona una orden para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la fila seleccionada
            string ordenSeleccionada = dgbOrders.CurrentRow.Cells["Comprador"].Value.ToString();
            var compradorSeleccionado = orderController.ObtainOrder().FirstOrDefault(c => c.Comprador == ordenSeleccionada);

            if (ordenSeleccionada == null)
            {
                MessageBox.Show("Numero de orden no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el formulario hijo y pasar los datos
            EditOrder editOrderForm = new EditOrder
            {
                Comprador = compradorSeleccionado.Comprador,
                Marca = compradorSeleccionado.Marca,
                Modelo = compradorSeleccionado.Modelo,
                Año = compradorSeleccionado.Año,
                Monto = compradorSeleccionado.Monto,
                Detalles = compradorSeleccionado.Detalles
            };

            // Mostrar formulario hijo
            if (editOrderForm.ShowDialog() == DialogResult.OK)
            {
                // Actualizar datos de las ordenes en el controlador
                compradorSeleccionado.Comprador = editOrderForm.Comprador;
                compradorSeleccionado.Marca = editOrderForm.Marca;
                compradorSeleccionado.Modelo = editOrderForm.Modelo;
                compradorSeleccionado.Año = editOrderForm.Año;
                compradorSeleccionado.Monto = editOrderForm.Monto;
                compradorSeleccionado.Detalles = editOrderForm.Detalles;


                // Actualizar la lista en el DataGridView
                UpdateOrderList();
            }
        }

        private void dgbOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que se haga clic en una fila válida
            if (e.RowIndex >= 0)
            {
                var row = dgbOrders.Rows[e.RowIndex];

                // Crear una orden con los datos de la fila seleccionada
                compradorSeleccionado = new Orden(
                    row.Cells["Comprador"].Value?.ToString(),
                    row.Cells["Marca"].Value?.ToString(),
                    row.Cells["Modelo"].Value?.ToString(),
                    row.Cells["Año"].Value?.ToString(),
                    row.Cells["Monto"].Value?.ToString(),
                    row.Cells["Detalles"].Value?.ToString()
                );
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgbOrders.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona una orden para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar la acción de eliminar
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta orden?", "Confirmación",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Obtener el índice de la fila seleccionada
                int indiceSeleccionado = dgbOrders.CurrentRow.Index;

                // Eliminar Orden del controlador
                orderController.DeleteOrder(indiceSeleccionado);

                // Actualizar la lista de Ordenes en el DataGridView
                UpdateOrderList();
            }
        }
    }
}
