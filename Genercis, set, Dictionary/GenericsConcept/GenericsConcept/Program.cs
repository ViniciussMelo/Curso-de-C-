using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();
            //PrintService<string> printService = new PrintService<string>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the " + (i + 1) + "º value:");
                int x = int.Parse(Console.ReadLine());

                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
