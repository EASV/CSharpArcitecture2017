using CustomerAppEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAppDAL
{
    public class FakeDB
    {
        #region FakeDB
        static int id = 1;
        static List<Customer> customers = new List<Customer>();
        #endregion
    }
}
