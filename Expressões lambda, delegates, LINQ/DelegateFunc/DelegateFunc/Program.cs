using DelegateFunc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateFunc
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

            //Func<Product, string> func = NameUpper;
            Func<Product, string> func = p => p.Name.ToUpper();

            //List<string> result = list.Select(NameUpper).ToList();
            //List<string> result = list.Select(func).ToList();
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        //static string NameUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}
    }
}
