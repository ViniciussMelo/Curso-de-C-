using System;
using System.Globalization;

namespace EstruturasRepetição
{
    class Program
    {
        static void Main(string[] args)
        {
            RepeatWhilePositive();
            RepeatFor();
        }

        static void RepeatWhilePositive()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (numero >= 0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("O número: " + numero + " é negativo.");
        }

        static void RepeatFor()
        {
            Console.WriteLine("Digite a quantidade de números inteiros a ser digitada:");
            int qtd = int.Parse(Console.ReadLine());
            double soma = 0.00;

            for(int  i = 1; i <= qtd; i++)
            {
                Console.Write("Digite o " + i + "º número: ");
                soma += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Soma: " + soma);
        }
    }
}
