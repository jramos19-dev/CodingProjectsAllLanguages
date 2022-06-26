using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;


namespace Packt.Shared
{
    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public Dbset<Customer> Customers { get; set; }
        public Dbset<Employ


    }


}
