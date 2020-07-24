using System;
using System.Globalization;
using System.Collections.Generic;
using Workout02.Entities;
using Workout02.Entities.Enums;

namespace Workout02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            System.Console.Write("Enter the number of shapes: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Shape #" +(i + 1)+ " data:");

                Console.Write("Rectangle or Circle (r/c) ? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

                if(type.ToString().ToLower() == "r"){
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, width, height));
                }
                else if (type.ToString().ToLower() == "c")
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(color, radius));
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }

            Console.WriteLine("\nSHAPE AREAS:");

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Color+ ", area: " + shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
