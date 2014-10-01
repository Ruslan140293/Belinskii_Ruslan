using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,a,b,c,d;
            Console.WriteLine("Введите четырехзначное число:");
            n = Convert.ToInt32(Console.ReadLine());
            if ((n < 1000) || (n > 9999)) return;
            a = n / 1000;
            b = (n / 100)%10;
            c = (n / 10)%10;
            d = n % 10;
            if (a + b == c + d)
            Console.WriteLine("TRUE");
            else
            Console.WriteLine("False");
            Console.ReadLine();
            return;
        }
    }
}
