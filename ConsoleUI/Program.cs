using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    // O: Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var p in productManager.GetAllByUnitPrice(40,50))
            {
                Console.WriteLine("{0}\t {1} \t {2}",p.ProductName,p.CategoryId,p.UnitPrice);
            }
        }
    }
}
