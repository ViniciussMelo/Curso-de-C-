using CompareHashSet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            /*Se não tiver o método gethashcode e equals implementados, compara a referência dos objetos*/
            Console.WriteLine(a.Contains(prod));
            /*---- -----*/

            Point p = new Point(5, 10);
            /*Quando o tipo for struct ele compara por valor*/
            Console.WriteLine(b.Contains(p));
            /*---- -----*/
        }
    }
}
