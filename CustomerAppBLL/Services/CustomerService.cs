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
        DALFacade facade;
        public CustomerService(DALFacade facade)
        {
            this.facade = facade;
        }

        public Customer Create(Customer cust)
        {
            using(var uow = facade.UnitOfWork)
            {
				var newCust = uow.CustomerRepository.Create(cust);
				uow.Complete();
				return newCust;
            }
        }

        public Customer Delete(int Id)
        {
			using (var uow = facade.UnitOfWork)
			{
				var newCust = uow.CustomerRepository.Delete(Id);
				uow.Complete();
				return newCust;
			}
        }

        public Customer Get(int Id)
        {
            using (var uow = facade.UnitOfWork)
			{
				return uow.CustomerRepository.Get(Id);
			}
        }

        public List<Customer> GetAll()
        {
			using (var uow = facade.UnitOfWork)
			{
                return uow.CustomerRepository.GetAll();
			}
        }

        public Customer Update(Customer cust)
        {
            using (var uow = facade.UnitOfWork)
            {
                var customerFromDb = uow.CustomerRepository.Get(cust.Id);
				if (customerFromDb == null)
				{
					throw new InvalidOperationException("Customer not found");
				}

				customerFromDb.FirstName = cust.FirstName;
				customerFromDb.LastName = cust.LastName;
				customerFromDb.Address = cust.Address;
                uow.Complete();
				return customerFromDb;
            }

        }
    }
}
