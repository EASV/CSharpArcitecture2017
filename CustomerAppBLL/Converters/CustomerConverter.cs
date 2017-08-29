using CustomerAppBLL.BusinessObjects;
using CustomerAppDAL.Entities;

namespace CustomerAppBLL.Converters
{
    class CustomerConverter
    {

        internal Customer Convert(CustomerBO cust)
        {
            return new Customer()
            {
                Id = cust.Id,
                Address = cust.Address,
                FirstName = cust.FirstName,
                LastName = cust.LastName
            };
        }

        internal CustomerBO Convert(Customer cust)
        {
            return new CustomerBO()
            {
                Id = cust.Id,
                Address = cust.Address,
                FirstName = cust.FirstName,
                LastName = cust.LastName
            };
        }
    }
}
