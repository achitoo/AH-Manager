using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador_1.Funciones
{
    internal class CustomerRepository
    {
        private List<Customer> customers = new List<Customer>();

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void UpdateCustomer(string dni, Customer updatedCustomer)
        {
            var customer = customers.FirstOrDefault(c => c.DNI == dni);
            if (customer != null)
            {
                customer.Name = updatedCustomer.Name;
                customer.Address = updatedCustomer.Address;
                customer.Contact = updatedCustomer.Contact;
                customer.Email = updatedCustomer.Email;
            }
        }

        public void DeleteCustomer(string dni)
        {
            var customer = customers.FirstOrDefault(c => c.DNI == dni);
            if (customer != null)
            {
                customers.Remove(customer);
            }
        }
    }
}
