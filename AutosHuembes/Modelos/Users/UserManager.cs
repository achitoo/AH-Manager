using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AutosHuembes.Modelos
{
    public class UserManager
    {
        public List<Usuarios> UserList { get; private set; }

        public UserManager()
        {
            UserList = new List<Usuarios>();
            EnsureFileExistsWithAdmin("users.txt"); // Verifica la existencia del archivo al instanciar UserManager
        }

        public void AddUser(Usuarios usuarios)
        {
            UserList.Add(usuarios);
        }

        public void EditUser(int indice, Usuarios usuarios)
        {
            if (indice >= 0 && indice < UserList.Count)
            {
                UserList[indice] = usuarios;
            }
        }

        public void DeleteUser(int indice)
        {
            if (indice >= 0 && indice < UserList.Count)
            {
                UserList.RemoveAt(indice);
            }
        }

        public void LoadFromFile(string rutaArchivo)
        {
            UserList.Clear();

            if (File.Exists(rutaArchivo))
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        if (datos.Length == 5) // Verificar que tenga 5 campos
                        {
                            UserList.Add(new Usuarios(
                                datos[0], // Nombre
                                datos[1], // Usuario
                                datos[2], // Correo
                                datos[3], // Contraseña
                                datos[4]  // Administrador
                            ));
                        }
                        else
                        {
                            MessageBox.Show($"Formato incorrecto en línea: {linea}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        public void SaveInFile(string rutaArchivo)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (var usuarios in UserList)
                {
                    sw.WriteLine($"{usuarios.Nombre},{usuarios.Usuario},{usuarios.Correo},{usuarios.Contraseña},{usuarios.Administrador}");
                }
            }
        }

        private void EnsureFileExistsWithAdmin(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
            {
                // Crear archivo y agregar usuario "Admin"
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    sw.WriteLine("Admin,Admin,admin@autoshuembes.com,Admin,Autorizado");
                }
            }

            // Cargar usuarios desde el archivo para que estén disponibles en UserList
            LoadFromFile(rutaArchivo);
        }
    }
}
