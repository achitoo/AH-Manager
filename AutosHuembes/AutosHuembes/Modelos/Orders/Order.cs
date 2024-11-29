using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosHuembes.Modelos
{
    public class Orden
    {
        // Propiedades de la clase Order
        public string Comprador { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public string Monto { get; set; }
        public string Detalles { get; set; }

        // Constructor sin parámetros (por defecto)
        public Orden() { }

        // Constructor con seis parámetros
        public Orden(string comprador, string marca, string modelo, string año, string monto, string detalles)
        {
            Comprador = comprador;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Monto = monto;
            Detalles = detalles;
        }
    }
}
