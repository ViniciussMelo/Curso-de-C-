using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números no vetor:");
            int n = int.Parse(Console.ReadLine());

            double[] vector = new double[n];

            for (int i = 0; i < vector.Length; i++ )
            {
                Console.Write("Digite o " +  (i + 1) + " número: " );
                vector[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.00;

            for (int i = 0; i < vector.Length; i++)
            {
                sum += vector[i];
            }

            double avg = sum / n;

            Console.WriteLine("Média: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
