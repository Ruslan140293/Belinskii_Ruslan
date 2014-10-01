using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab7
{
    class Program
    {
        static int pos(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
                return 2;
            else
            {
                return (pos(n - 2) * pos(n - 1));
            }
        }
        static void Main(string[] args)
        {
            int n, answer;
            Console.Write("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            answer = pos(n);
            Console.WriteLine("{0} это {1} -е число последовательности", answer, n);
            Console.ReadLine();
        }
    }
}
