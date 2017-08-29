using CustomerAppDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAppDAL.Context
{
    class InMemoryContext : DbContext
    {
        static DbContextOptions<InMemoryContext> options =
            new DbContextOptionsBuilder<InMemoryContext>()
                         .UseInMemoryDatabase("TheDB")
                         .Options;

        //Options That we want in Memory
        public InMemoryContext() : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
