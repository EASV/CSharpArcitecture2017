using CustomerAppDAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CustomerAppDAL.Repositories
{
    class CustomerRepositoryFakeDB : ICustomerRepository
    {
        #region FakeDB
        private static int Id = 1;
        private static List<Customer> Customers = new List<Customer>();
        #endregion

        public Customer Create(Customer cust)
        {
            Customer newCust;
            Customers.Add(newCust = new Customer()
            {
                Id = Id++,
                FirstName = cust.FirstName,
                LastName = cust.LastName,
                Address = cust.Address
            });
            return newCust;
        }

        public Customer Delete(int Id)
        {
            var cust = Get(Id);
            Customers.Remove(cust);
            return cust;
        }

        public Customer Get(int Id)
        {
            return Customers.FirstOrDefault(x => x.Id == Id);
        }

        public List<Customer> GetAll()
        {
            return new List<Customer>(Customers);
        }
    }
}
