using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_2
{
    class Program
    {
        delegate double del(double x);
        static double Fotx(double x)
        {
            return -(5 * Math.Cos(3 * x) - Math.Pow(x, 4.0/ 3.0));
        }
        static double test(double x)
        { return -(x * x); }
        static double funk(del Fotx, double a, double b, double E)
        {
            double f = 0, g = 0;
            {
                double x = a, d = 0.1;
                while (Math.Abs(d) > E / 4)
                {
                    if (x > b) { break; }
                    g = Fotx(x);
                    f = Fotx(x + d);
                    if (g > f) { x = x + d; d = -d / 4; x = x + d; }
                    else { x = x + d; }
                }
            }
            return f;
        }
        static void Main(string[] args)
        {
            double a = 2.5, b = 4.0, e = 0.001;
            Console.WriteLine(funk(Fotx, a, b, e));
            Console.ReadLine();
        }
    }
}