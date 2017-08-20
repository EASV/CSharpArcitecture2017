using CustomerAppEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAppDAL
{
    public class FakeDB
    {
        #region FakeDB
        public static int Id = 1;
        public static List<Customer> Customers = new List<Customer>();
        #endregion
    }
}
