using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab9_var8
{
    class Program
    {
        public struct tochka
        {
            public double x;
            public double y;
        }
        public struct otrezok
        {
            public double dlina;
        }
        public struct okrugnost
        {
            public tochka centrOkr;
            public otrezok rOkr;
            public double dlOkr()
            {
                return 2 * Math.PI * (rOkr.dlina);
            }
            public double sOkr()
            {
                return Math.PI * (rOkr.dlina) * (rOkr.dlina);
            }
        }
        static void proverka(ref okrugnost a)
        {
            if (a.rOkr.dlina < 0)
            {
                a.rOkr.dlina = 5;            
            }
        }
        static double obS(okrugnost a, okrugnost b)
        {
            return a.sOkr() + b.sOkr();
        }
        static void Main(string[] args)
        {
            //tochka t;
            //otrezok o;
            okrugnost p1, p2, p3;
            Console.WriteLine("Введите координаты точки X");
            p1.centrOkr.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки Y");
            p1.centrOkr.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину отрезка");
            p1.rOkr.dlina = Convert.ToDouble(Console.ReadLine());
            proverka(ref p1);
            Console.WriteLine("X={0},Y={1}, Ваш отрезок равен {2}, Длина окружности равна {3}, Площадь окружности равна {4}", p1.centrOkr.x, p1.centrOkr.y, p1.rOkr.dlina, p1.dlOkr(), p1.sOkr());
            //////////////////////////
            Console.WriteLine("Введите координаты точки X");
            p2.centrOkr.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки Y");
            p2.centrOkr.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину отрезка");
            p2.rOkr.dlina = Convert.ToDouble(Console.ReadLine());
            proverka(ref p2);
            Console.WriteLine("X={0},Y={1}, Ваш отрезок равен {2}, Длина окружности равна {3}, Площадь окружности равна {4}", p2.centrOkr.x, p2.centrOkr.y, p2.rOkr.dlina, p2.dlOkr(), p2.sOkr());
            ////////////////////
            Console.WriteLine("Введите координаты точки X");
            p3.centrOkr.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки Y");
            p3.centrOkr.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину отрезка");
            p3.rOkr.dlina = Convert.ToDouble(Console.ReadLine());
            proverka(ref p3);
            Console.WriteLine("X={0},Y={1}, Ваш отрезок равен {2}, Длина окружности равна {3}, Площадь окружности равна {4}", p3.centrOkr.x, p3.centrOkr.y, p3.rOkr.dlina, p3.dlOkr(), p3.sOkr());
            /////////////////
            Console.WriteLine("Общая площадь 1 и 2 равна {0},Общая площадь 2 и 3 равна {1},Общая площадь 1 и 3 равна {2}", obS(p1, p2), obS(p2, p3), obS(p1, p3));
            Console.ReadLine();
        }
    }
}