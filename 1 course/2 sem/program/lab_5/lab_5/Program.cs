using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_5
{
    class Int
    {
        public int a;
        public int b;
        public Int() { a = 1; b = 1; }
        public Int(int A, int B) { a = A; b = B; }
        public static Int operator +(Int a, Int b)
        {
            Int c = new Int();
            if ((a.a + b.a > int.MaxValue || a.a + b.a < int.MinValue) || (a.b + b.b > int.MaxValue || a.b + b.b < int.MinValue)) { Console.WriteLine("errore"); return c; };
            c.a = a.a + b.a;
            c.b = a.b + b.b;
            return c;
        }
        public static Int operator -(Int a, Int b)
        {
            Int c = new Int();
            if ((a.a - b.a > int.MaxValue || a.a - b.a < int.MinValue) || (a.b - b.b > int.MaxValue || a.b - b.b < int.MinValue)) { Console.WriteLine("errore"); return c; };
            c.a = a.a - b.a;
            c.b = a.b - b.b;
            return c;
        }
        public static Int operator *(Int a, Int b)
        {
            Int c = new Int();
            if ((a.a * b.a > int.MaxValue || a.a * b.a < int.MinValue) || (a.b * b.b > int.MaxValue || a.b * b.b < int.MinValue)) { Console.WriteLine("errore"); return c; };
            c.a = a.a * b.a;
            c.b = a.b * b.b;
            return c;
        }
        public static Int operator /(Int a, Int b)
        {
            Int c = new Int();
            if ((a.a / b.a > int.MaxValue || a.a / b.a < int.MinValue) || (a.b / b.b > int.MaxValue || a.b / b.b < int.MinValue)) { Console.WriteLine("errore"); return c; };
            c.a = a.a / b.a;
            c.b = a.b / b.b;
            return c;
        }
        public static Int operator %(Int a, Int b)
        {
            Int c = new Int();
            if ((a.a % b.a > int.MaxValue || a.a % b.a < int.MinValue) || (a.b % b.b > int.MaxValue || a.b % b.b < int.MinValue)) { Console.WriteLine("errore"); return c; };
            c.a = a.a % b.a;
            c.b = a.b % b.b;
            return c;
        }
        public void vivod()
        { Console.WriteLine(a + "\t" + b); }
    }
    class Program
    {
        public static void menu()
        {
            Console.WriteLine("Нажмите 1 для +");
            Console.WriteLine("Нажмите 2 для -");
            Console.WriteLine("Нажмите 3 для *");
            Console.WriteLine("Нажмите 4 для /");
            Console.WriteLine("Нажмите 5 для %");
            Console.WriteLine("Нажмите 6 для введения новых данных");
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            b = Convert.ToInt32(Console.ReadLine());
            Int A = new Int(a, b);
            Console.WriteLine("Введите a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            b = Convert.ToInt32(Console.ReadLine());
            Int B = new Int(a, b);
            char otvet = ' ';
            Int C = new Int();
            while (1 == 1)
            {
                menu();
                otvet = Convert.ToChar(Console.ReadLine());
                switch (otvet)
                {
                    case '1': C = A + B; C.vivod(); break;
                    case '2':
                        Console.WriteLine("Нажмите 1 для А-Б");
                        Console.WriteLine("Нажмите 2 для Б-А");
                        otvet = Convert.ToChar(Console.ReadLine());
                        if (otvet == '1') { C = A - B; C.vivod(); break; }
                        if (otvet == '2') { C = B - A; C.vivod(); break; }
                        break;
                    case '3': C = A * B; C.vivod(); break;
                    case '4':
                        Console.WriteLine("Нажмите 1 для А-Б");
                        Console.WriteLine("Нажмите 2 для Б-А");
                        otvet = Convert.ToChar(Console.ReadLine());
                        if (otvet == '1') { C = A / B; C.vivod(); break; }
                        if (otvet == '2') { C = B / A; C.vivod(); break; }
                        break;
                    case '5':
                        Console.WriteLine("Нажмите 1 для А-Б");
                        Console.WriteLine("Нажмите 2 для Б-А");
                        otvet = Convert.ToChar(Console.ReadLine());
                        if (otvet == '1') { C = A % B; C.vivod(); break; }
                        if (otvet == '2') { C = B % A; C.vivod(); break; }
                        break;
                    case '6': Console.WriteLine("Введите a:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите b:");
                        b = Convert.ToInt32(Console.ReadLine());
                        A = new Int(a, b);
                        Console.WriteLine("Введите a:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите b:");
                        b = Convert.ToInt32(Console.ReadLine());
                        B = new Int(a, b);
                        break;
                    default: return;
                }
            }
        }
    }
}
