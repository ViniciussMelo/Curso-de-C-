using System;

namespace EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simples
            int hora = 5;

            Console.WriteLine("Bom dia!");

            if(hora > 5)
            {
                Console.WriteLine("Boa tarde!");
            }

            Console.WriteLine("Boa noite!");


            Console.WriteLine("----------------------");
            //Composta
            Console.WriteLine("Digite um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }

            Console.WriteLine("--------------");

            //Encadeada
            Console.WriteLine("Digite a hora atual: (inteiro)");
            int horaAtual = int.Parse(Console.ReadLine());

            if (horaAtual < 12)
            {
                Console.WriteLine("Bom dia");
            } else if (horaAtual < 18)
            {
                Console.WriteLine("Boa tarde");
            } else
            {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}
