using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите значени Х");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Exp(Math.Sqrt(Math.Pow(Math.Pow(x, 2) - 1.8, 3.0 / 4.0))) + Math.Pow(x, 4.5) / Math.Atan(Math.Pow(Math.Pow(3 * x, 2) + 2.0 / 3.0, 4)) - Math.Sqrt(Math.Pow(x, 3.2)));
            Console.ReadLine();
        }
    }
}
