using System;

namespace Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Name = "teste";

            Console.WriteLine("Nome: " + produto.Name);
        }
    }
}
