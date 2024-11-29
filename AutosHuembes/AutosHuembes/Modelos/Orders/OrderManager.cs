using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutosHuembes.Modelos
{
    public class OrderManager
    {
        public List<Orden> OrderList { get; private set; }

        public OrderManager()
        {
            OrderList = new List<Orden>();
        }

        public void AddOrder(Orden orden)
        {
            OrderList.Add(orden);
        }

        public void EditOrder(int indice, Orden orden)
        {
            if (indice >= 0 && indice < OrderList.Count)
            {
                OrderList[indice] = orden;
            }
        }

        public void DeleteOrder(int indice)
        {
            if (indice >= 0 && indice < OrderList.Count)
            {
                OrderList.RemoveAt(indice);
            }
        }

        public void LoadFromFile(string rutaArchivo)
        {
            OrderList.Clear(); // Limpiar la lista antes de cargar

            if (File.Exists(rutaArchivo))
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        if (datos.Length == 6) // Verificar que tenga 6 campos
                        {
                            OrderList.Add(new Orden(
                                datos[0], // Comprador
                                datos[1], // Marca
                                datos[2], // Modelo
                                datos[3], // Año
                                datos[4], // Monto
                                datos[5]  // Detalles
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
                foreach (var orden in OrderList)
                {
                    sw.WriteLine($"{orden.Comprador},{orden.Marca},{orden.Modelo},{orden.Año},{orden.Monto},{orden.Detalles}");
                }
            }
        }
    }
}
