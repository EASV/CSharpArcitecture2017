using CustomerAppDAL.Entities;
using System.Collections.Generic;

namespace CustomerAppDAL
{
    public interface ICustomerRepository
    {
        //C
        Customer Create(Customer cust);
        //R
        List<Customer> GetAll();
        Customer Get(int Id);
        //U
        //No Update for Repository, It will be the task of Unit of Work
        //D
        Customer Delete(int Id);
    }
}
