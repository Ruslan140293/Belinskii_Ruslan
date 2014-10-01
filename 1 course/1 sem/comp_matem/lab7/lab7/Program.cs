using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab7
{
    class Program
    {
        static int NOD(int a, int b)
        {
            int bol = 0;
            int men = 0;
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a > b)
            {
                bol = a;
                men = b;
            }
            else
            {
                bol = b;
                men = a;
            }
            int nod = 0;
            bool f = true;
            int o = 0;//переменная для обмена
            while (f)
                if (bol % men == 0)
                {
                    nod = men;
                    f = false;
                }
                else
                {
                    bol = bol % men;
                    if (bol < men)
                    {
                        o = bol;
                        bol = men;
                        men = o;
                    }
                }
            return nod;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числитель первой дроби:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числитель второй дроби");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби");
            int d = Convert.ToInt32(Console.ReadLine());
            int nod = NOD(b, d);
            int nok = b * d / nod;
            int znam = nok;
            a = a *nok/b;
            c = c * nok/d;
            Console.WriteLine("НОК = {0},НОД = {1},первая дробь {2}/{0},вторая дробь {3}/{0}", nok, nod, a, c);
            Console.ReadLine();
        }
    }
}
