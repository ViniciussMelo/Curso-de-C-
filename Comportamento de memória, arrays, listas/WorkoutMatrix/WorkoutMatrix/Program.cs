using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of order: ");
            int order = int.Parse(Console.ReadLine());
            int count = 0;

            //lines, columns
            int[,] matrix = new int[order, order];

            for (int i = 0; i < order; i++)
            {
                for (int a = 0; a < order; a++)
                {
                    Console.Write("Enter the number of line " + (a + 1) + " and column " + (i + 1) + ": ");
                    matrix[i, a] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < order; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }

            for (int i = 0; i < order; i++)
            {
                for (int a = 0; a < order; a++)
                {
                    if (matrix[i, a] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("\nNegative numbers: " + count);

            Console.WriteLine("\n\nMatriz: ");

            for (int i = 0; i < order; i++)
            {
                for (int a = 0; a < order; a++)
                {
                    Console.Write(matrix[i, a] + " ");
                }
                Console.WriteLine("");
            }

        }
    }
}
