using System;

namespace ConversaoImplicitaECasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão implicita
            float x = 4.5f;

            double y = x;

            Console.WriteLine(y);
            // -- \\

            //Casting
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);
            // -- \\


            double c;
            int d;

            a = 5.1;
            d = (int)a;//Perdeu a casa decimal

            Console.WriteLine(d);

            int e = 5;
            int f = 2;

            //double resultado = e / f;//Compilador entende que a divisão resulta em um inteiro
            double resultado = (double) e / f;

            Console.WriteLine(resultado);

        }
    }
}
