using ConsoleApplication1.Entitites;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>();

            Console.WriteLine("Enter the full path: ");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);

                        prod.Add(new Product(name, price));
                    }
                }

                double average = prod.Select(p => p.Price).Average();
                Console.WriteLine("Average price: " + average.ToString("F2", CultureInfo.InvariantCulture));

                List<Product> prod2 = (from p in prod
                                       where p.Price < average
                                       orderby p.Name descending
                                       select p).ToList();

                foreach (Product p in prod2)
	            {
                    Console.WriteLine(p.Name);
	            }
                     
            }
            catch (IOException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
