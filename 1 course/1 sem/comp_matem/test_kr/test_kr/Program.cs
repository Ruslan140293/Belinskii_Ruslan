using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_kr
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            int c;
            int s = 0;
            while (true)
            {
                a = Convert.ToChar(Console.ReadLine());
                if (Char.IsDigit(a))
                {
                    c= Convert.ToInt32(a);
                    s += c - 48;
                }
                if (a == 'n')
                    break;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
