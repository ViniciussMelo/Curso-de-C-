using GetHashCodeXEquals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCodeXEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "email@gmail.com"};
            Client b = new Client { Name = "Alex", Email = "email@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
