using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab7
{
    class Program
    {
        static int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            else
            {
                int answer;
                answer = factorial(n - 1) * n;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            int n, answer;
            Console.Write("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            answer = factorial(n);
            Console.WriteLine("факториал {0} = {1}",n, answer);
            Console.ReadLine();
        }
    }
}
