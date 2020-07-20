using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1 = Calculator.Sum(new double[] { 2.0, 3.0 });
            double s2 = Calculator.Sum(new double[] { 2.0, 4.0, 3.0 });
            double s3 = Calculator.Sum(2, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
