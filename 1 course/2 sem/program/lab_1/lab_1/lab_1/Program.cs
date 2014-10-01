using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_1
{
    class Program
    {
        delegate double integral(double x);
        static double test(double x)
        {
            return 2;
        }
        static double formula(double x)
        {
            return Math.Sqrt(4 + Math.Pow(x, 2));
        }
        static double func(integral formula, double a, double b, double e)
        {
            int n = 10;
            double h = 0;
            double sum = 0, sum1 = 0;
            do
            {
                h = (b - a) / n;
                sum = 0; sum1 = 0;
                for (double i = a; i < b; i += h)
                {
                    sum += formula(i);
                }
                sum = h * sum;
                n = 2 * n;
                h = (b - a) / n;
                for (double i = a; i < b; i += h)
                {
                    sum1 += formula(i);
                }
                sum1 = h * sum1;
                n = 2 * n;
            }
            while (Math.Abs(sum - sum1) > e);
            return sum1;
        }
        static void Main(string[] args)
        {
            double a = 0, b = 3, e = 0.001;
            Console.WriteLine(func(test, a, b, e));
            Console.WriteLine(func(formula, a, b, e));
            Console.ReadLine();
        }
    }
}