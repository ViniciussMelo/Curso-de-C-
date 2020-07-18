using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números: (inteiros)");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior número = " + resultado);
        }

        static int Maior(int n1, int n2, int n3)
        {
            int maiorNumero = 0;

            if(n1 > n2 && n1 > n3)
            {
                maiorNumero = n1;
            } else if (n2 > n3)
            {
                maiorNumero = n2;
            } else
            {
                maiorNumero = n3;
            }

            return maiorNumero;
        }
    }
}
