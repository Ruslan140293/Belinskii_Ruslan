using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab6
{
    class Program
    {
        struct price
        {
            public char[] name;
            public char[] nameshop;
            public double st;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество товаров:");
            int k = Convert.ToInt32(Console.ReadLine());
            int menu;
            int t;
            price s1;
            s1.name = new char[k];
            while (true)
            {
                Console.WriteLine("Нажмите 1 чтобы внести базу");
                Console.WriteLine("Нажмите 2 чтобы отсортировать в алфавитном порядке");
                Console.WriteLine("нажмите 3 чтобы найти товар и информацию о нем");
                Console.WriteLine("нажмите 4 для выхода");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        for (int i = 0; i < k; i++)
                        {
                            Console.Write("Введите название товара ОДИН символ:");
                            s1.name[i] = Convert.ToChar(Console.ReadLine());
                        }

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("ERRORE");
                        break;
                }
            }
        }
    }
}
