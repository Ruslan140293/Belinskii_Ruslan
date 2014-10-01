using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2_b_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2, x, y;
                Console.WriteLine("Введите первую координату верхней левой вершины");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите вторую координату верхней левой вершины");
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите первую координату нижней правой вершины");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите вторую координату нижней правой вершины");
                y2 = Convert.ToInt32(Console.ReadLine());
                if (x1 > x2 || y2 > y1)
                {
                    Console.WriteLine("Вы перепутали вершины.");
                    Console.ReadLine();
                    return;
                }
            //придурок поставь тут цикл типа "до" выперепутали вершины повторите
            if (x1 == x2 || y1 == y2)
            {
                Console.WriteLine("Ваши точки лежать друг на друге");
                Console.ReadLine();
                return;
            }
            //тут тоже должен быть цикл "до" 
            Console.WriteLine("Введите первую координату точки А");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую координату точки А");
            y = Convert.ToInt32(Console.ReadLine());           
            if ((x2 >= x && x >= x1) && (y1 >= y && y >= y2))
                Console.Write("TRUE");
            else
                Console.Write("False");
            Console.ReadLine();
            return;
        }
    }
}
