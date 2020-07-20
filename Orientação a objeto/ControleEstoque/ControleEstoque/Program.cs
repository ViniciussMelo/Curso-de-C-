using System;
using System.Globalization;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto;
            produto = new Produto();
            int opc = 0;

            do
            {
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Consultar estoque");
                Console.WriteLine("3 - Adicionar produto");
                Console.WriteLine("4 - Remover produto");
                Console.WriteLine("5 - Sair");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write("Digite o nome:");
                        produto.Name = Console.ReadLine();

                        Console.Write("Digite o preco: ");
                        try
                        {
                            produto.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        } catch (FormatException fe)
                        {
                            Console.WriteLine("Número inválido!");
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("Dados do produto: " + produto);
                        break;

                    case 3:
                        Console.Write("Digite a quantidade:");
                        try
                        {
                            int quantidade;
                            quantidade = int.Parse(Console.ReadLine());

                            produto.AddProducts(quantidade);
                        }
                        catch (FormatException fe)
                        {
                            Console.WriteLine("Deve ser um número!");
                        }
                        break;

                    case 4:
                        int quatidade;
                        Console.Write("Digite a quantidade:");
                        try
                        {
                            quatidade = int.Parse(Console.ReadLine());

                            produto.RemoveProducts(quatidade);
                        }
                        catch (FormatException fe)
                        {
                            Console.WriteLine("Deve ser um número!");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Terminou!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opc != 5);
        }
    }
}
