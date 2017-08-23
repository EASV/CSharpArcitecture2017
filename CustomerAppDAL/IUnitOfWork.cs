using System;
namespace CustomerAppDAL
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository CustomerRepository { get; }

        int Complete();
    }
}
