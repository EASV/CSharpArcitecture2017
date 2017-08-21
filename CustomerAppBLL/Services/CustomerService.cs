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
            return null;
        }

        public Customer Delete(int Id)
        {
            return null;
        }

        public Customer Get(int Id)
        {
            return null;
        }

        public List<Customer> GetAll()
        {
            return null;
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
            //Save Changes
            return customerFromDb;
        }
    }
}
