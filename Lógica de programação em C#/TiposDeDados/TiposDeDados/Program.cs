using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';//Aspas simples char
            char letra = '\u0041';///unicode
            byte n1 = 255;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483647L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Vinicius Melo";//string aspas duplas
            object obj1 = "Vinicius";
            object obj2 = 4.5f;

            int minValue = int.MinValue;
            int maxValue = int.MaxValue;
            sbyte sb = sbyte.MinValue;
            decimal dec = decimal.MaxValue;

            //Overflow
            n1++;

            /*Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);*/

            Console.WriteLine(minValue);
            Console.WriteLine(maxValue);
            Console.WriteLine(sb);
            Console.WriteLine(dec);
        }
    }
}
