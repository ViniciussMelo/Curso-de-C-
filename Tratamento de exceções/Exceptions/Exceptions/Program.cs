using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Primeiro número: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Segundo número: ");
                int n2 = int.Parse(Console.ReadLine());
                
                int divide = n1 / n2;
                Console.WriteLine("result" + divide);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}
