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
            ProductTest();
            //CategoryTest();


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var c in categoryManager.GetAll())
            {
                Console.WriteLine(c.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProducDetails();

            if (result.Success)
            {
                foreach (var p in productManager.GetProducDetails().Data)
                {
                    Console.WriteLine("{0}\t {1} \t {2} \t {3}", p.ProductId, p.ProductName, p.CategoryName, p.UnitsInStock);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
