using System;
using System.Globalization;

namespace Workout02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de quartos na sua casa:");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu último nome, idade e altura na mesma linha (com espaços):");
            string[] vetor = Console.ReadLine().Split(' ');
            string lastName = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine("------------");
            Console.WriteLine("Nome: "+ nome);
            Console.WriteLine("Qtd quartos: " + qtdQuartos);
            Console.WriteLine("Preço: "+preco);
            Console.WriteLine("Sobrenome: "+lastName);
            Console.WriteLine("Idade: "+idade);
            Console.WriteLine("Altura: "+altura.ToString("F2"));
        }
    }
}
