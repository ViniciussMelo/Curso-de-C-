using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorParamsRefEOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //out e ref: Code smells (desgin ruim)

            //ref obriga que a variável seja iniciada no ref.
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            //out n obriga inicialização da variável out, e devolve o valor na variável que foi indicado o "out"
            int b = 10;
            int triple;
            Calculator.Triple(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
