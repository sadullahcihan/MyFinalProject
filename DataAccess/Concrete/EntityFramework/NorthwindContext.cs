using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Connext: the connection of DB tables and project classes
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public  DbSet <Product> Products { get; set; } //which class refers to which table
        public DbSet <Category> Categories { get; set; } //DbSet<ClassName> TableNameInDb
        public DbSet <Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
