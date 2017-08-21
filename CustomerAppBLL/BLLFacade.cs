using CustomerAppBLL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAppBLL
{
    public class BLLFacade
    {
        public ICustomerService CustomerService
        {
            get { return new CustomerService(); }
        }
    }
}
