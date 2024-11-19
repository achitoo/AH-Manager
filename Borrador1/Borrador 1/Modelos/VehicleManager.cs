using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Borrador_1.Modelos;
using System.Windows.Forms;
using System.IO;


namespace Borrador_1.Modelos
{
    internal class VehicleManager
    {
        public List<Vehicle> VehicleList { get; private set; }

        public VehicleManager()
        {
            VehicleList = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            VehicleList.Add(vehicle);
        }

        public void EditVehicle(int indice, Vehicle vehicle)
        {
            if (indice >= 0 && indice < VehicleList.Count)
            {
                VehicleList[indice] = vehicle;
            }
        }

        public void DeleteVehicle(int indice)
        {
            if (indice >= 0 && indice < VehicleList.Count)
            {
                VehicleList.RemoveAt(indice);
            }
        }

        public void LoadFromFile(string rutaArchivo)
        {
            VehicleList.Clear();
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        if (datos.Length == 5)
                        {
                            VehicleList.Add(new Vehicle(
                                datos[0], datos[1], datos[2], datos[3], datos[4]
                            ));
                        }
                    }
                }
            }
        }

        public void SaveInFile(string rutaArchivo)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (var vehicle in VehicleList)
                {
                    sw.WriteLine($"{vehicle.Marca},{vehicle.Modelo},{vehicle.Detalles},{vehicle.Año},{vehicle.MontoTotal}");
                }
            }
        }

    }
}
