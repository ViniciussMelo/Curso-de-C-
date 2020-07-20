using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposRefETiposValor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Tipo referência: ponteiros, devem ser instanciados usando new ou apontar pra um objeto já existente, aceita null, tem herança
             Tipo valor: caixas, não precisa instanciar dando um new, não aceita null, não tem herança (mas pode implementar interface)
             */
            //tipo "struct" deve ser inicializado.
            Point p;
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new Point();

            Console.WriteLine(p);
        }
    }
}
