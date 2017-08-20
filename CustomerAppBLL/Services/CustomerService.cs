using System;
using System.Collections.Generic;
using System.Text;
using CustomerAppEntity;
using CustomerAppDAL;
using System.Linq;

namespace CustomerAppBLL.Services
{
    class CustomerService : ICustomerService
    {
        public Customer Create(Customer cust)
        {
            Customer newCust;
            FakeDB.Customers.Add(newCust = new Customer()
            {
                Id = FakeDB.Id++,
                FirstName = cust.FirstName,
                LastName = cust.LastName,
                Address = cust.Address
            });
            return newCust;
        }

        public Customer Delete(int Id)
        {
            var cust = Get(Id);
            FakeDB.Customers.Remove(cust);
            return cust;
        }

        public Customer Get(int Id)
        {
            return FakeDB.Customers.FirstOrDefault(x => x.Id == Id);
        }

        public List<Customer> GetAll()
        {
            return new List<Customer>(FakeDB.Customers);
        }

        public Customer Update(Customer cust)
        {
            var customerFromDb = Get(cust.Id);
            if(customerFromDb == null)
            {
                throw new InvalidOperationException("Customer not found");
            }
            customerFromDb.FirstName = cust.FirstName;
            customerFromDb.LastName = cust.LastName;
            customerFromDb.Address = cust.Address;
            return customerFromDb;
        }
    }
}
