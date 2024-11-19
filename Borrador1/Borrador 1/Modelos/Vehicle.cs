using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador_1.Modelos
{
    public class Vehicle
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Detalles { get; set; }
        public string Año { get; set; }
        public string MontoTotal { get; set; }

        public Vehicle(string marca, string modelo, string detalles, string año, string montoTotal)
        {
            Marca = marca;
            Modelo = modelo;
            Detalles = detalles;
            Año = año;
            MontoTotal = montoTotal;
        }
    }
}
