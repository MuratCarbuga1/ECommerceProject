using System;
using ECommerceProject.Business.Concrete;
using ECommerceProject.DataAccess.Concrete;

namespace ECommerceProject
{
    class Program
    {
        static void Main(string[] args)
        {
         

            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            Console.WriteLine("--- E-Commerce Product List ---");
            Console.WriteLine("-------------------------------");

            
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("Product ID: " + product.ProductId + " | Product Name: " + product.ProductName + " | Price: " + product.UnitPrice + " TL");
            }

            Console.WriteLine("-------------------------------");
            Console.ReadLine(); 
        }
    }
}