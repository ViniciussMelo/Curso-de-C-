using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 21;
            double saldo = 10.35784;
            string nome = "Maria";

            //Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //Interpolação versão C# >= 6
            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos" + " e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            /*Console.Write("Olá");
            Console.WriteLine(", antes sem quebra de linha!");
            Console.WriteLine("Agora tem");
            Console.WriteLine("--------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));//Numero e casas
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));//imprimir com ponto ao invés da vírgula*/
        }
    }
}
