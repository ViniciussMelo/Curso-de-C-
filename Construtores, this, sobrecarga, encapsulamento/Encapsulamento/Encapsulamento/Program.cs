using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Digite o nome: ");
            produto.SetName(Console.ReadLine());
            Console.WriteLine("Nome: " + produto.GetName());
        }
    }
}
