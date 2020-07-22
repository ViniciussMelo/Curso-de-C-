using System;
using System.Globalization;

namespace DateTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine(d4);
            Console.WriteLine(d5);

            DateTime d6 = DateTime.Parse("2000-06-10 03:00:00");
            DateTime d7 = DateTime.Parse("10/06/2000 03:00:00");
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            DateTime d8 = DateTime.ParseExact("2000-06-10", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d9 = DateTime.ParseExact("2000-06-10 03:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
        }
    }
}
