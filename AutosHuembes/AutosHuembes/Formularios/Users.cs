using System;
using System.Windows.Forms;
using AutosHuembes.FormulariosHijos;
using AutosHuembes.Modelos;

namespace AutosHuembes.Formularios
{
    public partial class Users : Form
    {
        private UserController userController;

        public Users()
        {
            InitializeComponent();
            userController = new UserController();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                userController.LoadUsers("users.txt");
                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGrid()
        {
            dgbUsers.Rows.Clear();
            foreach (var user in userController.ObtainUser())
            {
                dgbUsers.Rows.Add(user.Nombre, user.Usuario, user.Correo, user.Contraseña, user.Administrador);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUser();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Utilizamos la propiedad NewUser para obtener el usuario creado
                    var newUser = addUserForm.NewUser;

                    // Agregar el usuario al controlador
                    userController.AddUser(newUser.Nombre, newUser.Usuario, newUser.Correo, newUser.Contraseña, newUser.Contraseña, newUser.Administrador);

                    // Refrescar la vista del DataGridView
                    RefreshDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgbUsers.SelectedRows.Count > 0)
                {
                    int index = dgbUsers.SelectedRows[0].Index;
                    var user = userController.ObtainUser()[index];

                    var editUserForm = new EditUser(user); // Asumiendo que el constructor recibe el usuario
                    if (editUserForm.ShowDialog() == DialogResult.OK)
                    {
                        var updatedUser = editUserForm.GetUser();
                        userController.EditUser(index, updatedUser);
                        RefreshDataGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor selecciona un usuario para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgbUsers.SelectedRows.Count > 0)
                {
                    int index = dgbUsers.SelectedRows[0].Index;
                    var confirmation = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.Yes)
                    {
                        userController.DeleteUser(index);
                        RefreshDataGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor selecciona un usuario para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
