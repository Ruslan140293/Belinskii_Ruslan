using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3a
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите размер последовательности");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Размер последовательности должен быть положительным");
                Console.ReadLine();
                return;
            }
            int[] A = new int[n];
            Console.WriteLine("Введите {0} элементов массива A", n);
            for (int i = 0; i < n; i++)
                A[i] = Convert.ToInt32(Console.ReadLine());
            int[] B = new int[n];
            Console.WriteLine("Введите {0} элементов массива B", n);
            for (int i = 0; i < n; i++)
                B[i] = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            for (int i = 0; i < n; i++)
            {
                int s = A[i] + B[i];
                p = s * p;
            }
                Console.WriteLine("Произведение:{0}",p);
                Console.ReadLine();
                int min = 0;
            for (int i=0; i<n;i++)
                if (A[i]<0)
                    A[i]=Math.Abs(A[i]);
            for (int j=0; j<n-1;j++)
            {
                for (int i=0;i<n-j-1;i++)
                    if(A[i]>A[i+1])
                    {
                        min=A[i];
                        A[i]=A[i+1];
                        A[i+1]=min;
                    }
            }
            Console.WriteLine("Последовательность элементов масива A по возврастанию модулей элементов:");
            for (int i=0;i<n;i++)
                Console.WriteLine(A[i]);
            Console.ReadLine();
            return;
        }
    }
}
