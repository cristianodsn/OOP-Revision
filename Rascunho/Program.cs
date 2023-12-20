using System;
using System.Globalization;

namespace Rascunho
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle;
            Console.WriteLine("Enter the width and height of the rectangle:");
            double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            rectangle = new Rectangle();
            rectangle.Width = width;
            rectangle.Height = heigth;

            Console.WriteLine("Area: " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimeter: " + rectangle.Peremeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + rectangle.Diagonal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
