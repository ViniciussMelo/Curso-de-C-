using System;
using System.Globalization;

namespace CondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
