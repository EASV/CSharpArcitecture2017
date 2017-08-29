using CustomerAppBLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAppBLL
{
    /// <summary>
    /// I made a Contract!!!!
    /// </summary>
    public interface ICustomerService
    {
        //C
        CustomerBO Create(CustomerBO cust);
        //R
        List<CustomerBO> GetAll();
        CustomerBO Get(int Id);
        //U
        CustomerBO Update(CustomerBO cust);
        //D
        CustomerBO Delete(int Id);
    }
}
