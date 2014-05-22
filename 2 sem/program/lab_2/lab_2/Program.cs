using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> krug=new List<int>();
            Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите m:");
            int m = Convert.ToInt32(Console.ReadLine());
            int k = m;
            for (int i = n; i > 0; i--)
                krug.Add(i);
            int sod = 0;
            while (krug.Count != 1)
            {
                if (k > krug.Count)
                {
                    while (k > krug.Count)
                        k = k - krug.Count;
                }
                sod = krug[k-1];
                krug.Remove(sod);
                k += m;
            }
            Console.WriteLine("Остался номер:");
            foreach(int z in krug)
                Console.Write(z);
            Console.ReadLine();

        }
    }
}
