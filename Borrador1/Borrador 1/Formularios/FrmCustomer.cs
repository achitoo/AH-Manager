using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Borrador_1.Funciones;

namespace Borrador_1.Formularios
{
    public partial class FrmCustomer : Form
    {
        private CustomerManager manager;
        private CustomerRepository repository;
        public FrmCustomer()
        {
            InitializeComponent();
            repository = new CustomerRepository();
            manager = new CustomerManager(repository);
            LoadCustomers();
        }

        private void btnCloseFrm_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.Show();
        }

        private void LoadCustomers()
        {
            dgbCustomers.DataSource = null;
            dgbCustomers.DataSource = manager.GetCustomers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            manager.AddCustomer(tbDNI.Text, tbName.Text, tbAddress.Text, tbNumber.Text, tbEmail.Text);
            LoadCustomers();
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgbCustomers.SelectedRows.Count > 0)
            {
                string dni = dgbCustomers.SelectedRows[0].Cells["DNI"].Value.ToString();
                manager.EditCustomer(dni, tbName.Text, tbAddress.Text, tbNumber.Text, tbEmail.Text);
                LoadCustomers();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgbCustomers.SelectedRows.Count > 0)
            {
                string dni = dgbCustomers.SelectedRows[0].Cells["DNI"].Value.ToString();
                manager.DeleteCustomer(dni);
                LoadCustomers();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para borrar");
            }
        }
        private void ClearFields()
        {
            tbDNI.Clear();
            tbName.Clear();
            tbAddress.Clear();
            tbNumber.Clear();
            tbEmail.Clear();
        }
    }
}
