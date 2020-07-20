using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;
            
            double? a = x ?? 5; //se o x for nul, pega o 5

            //Pegar o valor, se n existir pega o valor padrão
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //verificar se existe ou não o valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //pegar o valor
            //Console.WriteLine(x.Value); - erro pois o x n tem valor
            Console.WriteLine(y.Value);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é null");
            }

            Console.WriteLine(a);
        }
    }
}
