using System.Collections.Generic;

namespace AutosHuembes.Modelos
{
    public class UserController
    {
        private UserManager userManager;

        public UserController()
        {
            userManager = new UserManager();
        }

        public List<Usuarios> ObtainUser()
        {
            return userManager.UserList;
        }

        public void SaveChanges()
        {
            string rutaArchivo = "users.txt";
            userManager.SaveInFile(rutaArchivo);
        }

        public void AddUser(string nombre, string usuario, string correo, string contraseña, string confirmar, string administrador)
        {
            if (contraseña != confirmar)
            {
                throw new System.Exception("La contraseña y la confirmación no coinciden.");
            }

            var usuarios = new Usuarios(nombre, usuario, correo, contraseña, administrador);
            userManager.AddUser(usuarios);
            SaveChanges();
        }

        public void EditUser(int indice, Usuarios usuarios)
        {
            userManager.EditUser(indice, usuarios);
            SaveChanges();
        }

        public void DeleteUser(int indice)
        {
            userManager.DeleteUser(indice);
            SaveChanges();
        }

        public void LoadUsers(string rutaArchivo)
        {
            userManager.LoadFromFile(rutaArchivo);
        }
    }
}
