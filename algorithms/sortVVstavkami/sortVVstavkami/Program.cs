using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortVVstavkami
{
    class Program
    {
        static void Main(string[] args)
        {
            int el,k;
            int[] A = new int[10];
            Random r = new Random();
            for (int i = 0; i < A.Length; i++)
                A[i] = r.Next(0, 100);
            for(int i=0;i<A.Length;i++)
                Console.WriteLine(A[i]);
            for (int j = 1; j < A.Length; j++)
            {
                el = A[j];
                k = j - 1;
                while (k >= 0 && A[k] > el)
                {
                    A[k + 1] = A[k];
                    k--;
                }
                A[k + 1] = el;
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < A.Length; i++)
                Console.WriteLine(A[i]);
            Console.ReadLine();
        }
    }
}
