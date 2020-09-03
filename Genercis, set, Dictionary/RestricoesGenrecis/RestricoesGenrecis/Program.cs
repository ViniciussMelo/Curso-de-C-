using Calculation.Entities;
using Calculation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the " + (i + 1) + "º product: ");
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
    }
}
