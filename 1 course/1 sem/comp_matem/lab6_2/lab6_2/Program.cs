using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab6_2
{
    class Program
    {
        struct price
        {
            public char name;
            public char nameshop;
            public decimal st;
        }
        static void Main(string[] args)
        {
            int menu;
            Console.WriteLine("Введите количество товаров:");
            int n = Convert.ToInt32(Console.ReadLine());
            price[] a = new price[n];
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Нажмите 1 чтобы внести базу");
                Console.WriteLine("Нажмите 2 чтобы отсортировать в алфавитном порядке");
                Console.WriteLine("нажмите 3 чтобы найти товар и информацию о нем");
                Console.WriteLine("нажмите 4 чтобы вывести");
                Console.WriteLine("нажмите 5 для выхода");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (menu)
                {
                    case 1:
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Введите название товара ОДИН символ:");
                            a[i].name = Convert.ToChar(Console.ReadLine());
                            Console.Write("Введите название магазина ОДИН символ:");
                            a[i].nameshop = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("Стоимость товара:");
                            a[i].st = Convert.ToDecimal(Console.ReadLine());
                        }
                        break;
                    case 2:
                        char a1;
                        char a2;
                        decimal a3;
                        for (int i = 0; i < n - 1; i++)
                            for (int j = 0; j < n - i - 1; j++)
                                if (a[j].name > a[j + 1].name)
                                {

                                    /*******************/
                                    a1 = a[j].name;
                                    a[j].name = a[j + 1].name;
                                    a[j + 1].name = a1;
                                    /*******************/
                                    a2 = a[j].nameshop;
                                    a[j].nameshop = a[j + 1].nameshop;
                                    a[j + 1].nameshop = a2;
                                    /*******************/
                                    a3 = a[j].st;
                                    a[j].st = a[j + 1].st;
                                    a[j + 1].st = a3;

                                }
                        Console.WriteLine();
                        Console.WriteLine("Отсортировано!!!");
                        Console.WriteLine();
                        break;
                    case 3:
                        bool f = false;
                        char c;
                        Console.WriteLine("Введите название товара");
                        c = Convert.ToChar(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                            if (c == a[i].name)
                            {
                                f = true;
                                Console.WriteLine("Название {0}, в магазине {1}, стоимость {2}", a[i].name, a[i].nameshop, a[i].st);
                            }
                        if (f == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Нет такого товара!!!");
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        for (int i = 0; i < n; i++)
                            Console.WriteLine("Товар {0},В магазине {1},Стоимость {2}", a[i].name, a[i].nameshop, a[i].st);
                        Console.WriteLine();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("ERRORE");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}