using DelegatePredicate.Entities;
using System;
using System.Collections.Generic;

namespace DelegatePredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>
            {
                new Product("Tv", 900.00),
                new Product("Mouse", 50.00),
                new Product("Tablet", 350.50),
                new Product("HD case", 80.90)
            };

            //list.RemoveAll(p => p.Price >= 100.00);
            list.RemoveAll(ProductTest);

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0; ;
        }
    }
}
