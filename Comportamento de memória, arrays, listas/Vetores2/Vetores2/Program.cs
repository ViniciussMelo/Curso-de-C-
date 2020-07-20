using System;
using System.Globalization;

namespace Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos:");

            int n = int.Parse(Console.ReadLine());

            Product[] vector = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do " +(i + 1)+ " produto : ");
                string name = Console.ReadLine();
                Console.Write("Digite o preço do " + (i + 1) + " produto : ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vector[i] = new Product { Name = name, Price = price };//deve-se instanciar o objeto pra poder alocar as informações, até então ele é nulo
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vector[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("Média: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
