using System;
using System.Collections.Generic;
using System.Text;
using CustomerAppEntity;
using CustomerAppDAL.Context;
using System.Linq;

namespace CustomerAppDAL.Repositories
{
    class CustomerRepositoryEFMemory : ICustomerRepository
    {
        InMemoryContext _context;

        public CustomerRepositoryEFMemory(InMemoryContext context)
        {
            _context = context;
        }

        public Customer Create(Customer cust)
        {
            _context.Customers.Add(cust);
            return cust;
        }

        public Customer Delete(int Id)
        {
            var cust = Get(Id);
            _context.Customers.Remove(cust);
            return cust;
        }

        public Customer Get(int Id)
        {
            return _context.Customers.FirstOrDefault(x => x.Id == Id);
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
    }
}
