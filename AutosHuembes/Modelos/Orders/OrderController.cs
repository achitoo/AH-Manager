using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosHuembes.Modelos
{
    public class OrderController
    {
        private OrderManager orderManager;

        public OrderController()
        {
            orderManager = new OrderManager();
        }

        public List<Orden> ObtainOrder()
        {
            return orderManager.OrderList;
        }

        public void SaveChanges()
        {
            string rutaArchivo = "order.txt";
            orderManager.SaveInFile(rutaArchivo);
        }

        public void AddOrder(string comprador, string marca, string modelo, string año, string monto, string detalles)
        {
            var orden = new Orden(comprador, marca, modelo, año, monto, detalles);
            orderManager.AddOrder(orden);
            SaveChanges();
        }

        public void EditOrder(int indice, Orden orden)
        {
            orderManager.EditOrder(indice, orden);
            SaveChanges();
        }

        public void DeleteOrder(int indice)
        {
            orderManager.DeleteOrder(indice);
            SaveChanges();
        }

        public void LoadOrders(string rutaArchivo)
        {
            orderManager.LoadFromFile(rutaArchivo);
        }
    }
}

