using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador_1.Funciones
{
    internal class CustomerManager
    {
        private CustomerRepository repository;

        public CustomerManager(CustomerRepository repo)
        {
            repository = repo;
        }

        public List<Customer> GetCustomers()
        {
            return repository.GetAllCustomers();
        }

        public void AddCustomer(string dni, string name, string address, string contact, string email)
        {
            var customer = new Customer
            {
                DNI = dni,
                Name = name,
                Address = address,
                Contact = contact,
                Email = email
            };
            repository.AddCustomer(customer);
        }

        public void EditCustomer(string dni, string name, string address, string contact, string email)
        {
            var updatedCustomer = new Customer
            {
                DNI = dni,
                Name = name,
                Address = address,
                Contact = contact,
                Email = email
            };
            repository.UpdateCustomer(dni, updatedCustomer);
        }

        public void DeleteCustomer(string dni)
        {
            repository.DeleteCustomer(dni);
        }
    }
}
