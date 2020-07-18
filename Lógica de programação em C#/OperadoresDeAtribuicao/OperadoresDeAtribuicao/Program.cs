using System;

namespace OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a++;//Atribui primeiro e depois incrementa
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);

            a--;
            Console.WriteLine(a);

            /*int c = 10;

            Console.WriteLine(c);

            c += 2;
            Console.WriteLine(c);

            c *= 3;
            Console.WriteLine(c);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);*/

        }
    }
}
