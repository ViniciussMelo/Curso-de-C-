using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];//duas linhas e três colunas

            Console.WriteLine("Length: " + mat.Length);

            Console.WriteLine("Lines: " + mat.Rank);

            Console.WriteLine("Lines: " + mat.GetLength(0));

            Console.WriteLine("Columns: " + mat.GetLength(1));
        }
    }
}
