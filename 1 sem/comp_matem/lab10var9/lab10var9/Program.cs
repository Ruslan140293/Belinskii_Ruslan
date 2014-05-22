using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab10var9
{
    class Program
    {
        public static char poisk;
        static int podshet(string[] s1Mas, char poisk, int k)
        #region funk
        {
            int[] kol1 = new int[s1Mas.Length];
            int z = 0;
            for (int i = 0; i < s1Mas.Length; i++)
            {
                for (int j = 0; j < s1Mas[i].Length; j++)
                {
                    if (s1Mas[i][j] == poisk)
                    {
                        z++;
                    }
                }
                kol1[i] = z;
                z = 0;
            }
            int it1 = 0;
            for (int i = 0; i < kol1.Length; i++)
            {
                if (kol1[i] >= k)
                {
                    it1++;
                }
            }
            return it1;
        }
        #endregion
        static void Main(string[] args)
        {
            int k = 0;
            char[] sep = { ' ', ',', '.', ':', '\t', '-', '?', '!', '\n', '\r' };
            Console.WriteLine("Введите первую строку:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            string s2 = Console.ReadLine();
            Console.WriteLine("Введите третью строку:");
            string s3 = Console.ReadLine();
            string[] s1Mas = s1.Split(sep);
            string[] s2Mas = s2.Split(sep);
            string[] s3Mas = s3.Split(sep);
            #region zadanie1
            {
                Console.WriteLine("Введите символ и количество");
                string p = Console.ReadLine();
                string[] ps = p.Split(sep,StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < ps.Length; i++)
                {
                    if (char.IsDigit(ps[i][0]))
                        k = Convert.ToInt32(ps[i]);
                    else
                        poisk = Convert.ToChar(ps[i]);
                }
                int[] itog = new int[3];
                itog[0] = podshet(s1Mas, poisk, k);
                itog[1] = podshet(s2Mas, poisk, k);
                itog[2] = podshet(s3Mas, poisk, k);

                int max = 0; int number = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (itog[i] > max)
                    {
                        max = itog[i]; number = i;
                    }
                }
                Console.WriteLine("Ответ:{0}", number + 1);
            }
            #endregion
            #region zadanie2
            {
                char poisk2;
                Console.WriteLine("Введите два символа:");
                string pss = Console.ReadLine();
                string[] psss = pss.Split(sep);
                poisk = psss[0][0];
                poisk2 = psss[1][0];
                int kol1 = 0;
                int kol2 = 0;
                int kol3 = 0;
                int j = 0;
                for (int i = 0; i < s1Mas.Length; i++)
                {
                    if (s1Mas[i].Contains(poisk) && s1Mas[i].Contains(poisk2))
                    {
                        j = s1Mas[i].Length;
                        if (kol1 < j) kol1 = j;
                    }
                }
                j = 0;
                for (int i = 0; i < s2Mas.Length; i++)
                {
                    if (s2Mas[i].Contains(poisk) && s2Mas[i].Contains(poisk2))
                    {
                        j = s2Mas[i].Length;
                        if (kol2 < j) kol2 = j;
                    }
                }
                j = 0;
                for (int i = 0; i < s3Mas.Length; i++)
                {
                    if (s3Mas[i].Contains(poisk) && s3Mas[i].Contains(poisk2))
                    {
                        j = s3Mas[i].Length;
                        if (kol3 < j) kol3 = j;
                    }
                }
                int maxnumbers = kol1; int q = 1;
                if (maxnumbers < kol2) { maxnumbers = kol2; q = 2; }
                if (maxnumbers < kol3) { maxnumbers = kol3; q = 3; }
                Console.WriteLine(q);
            }
#endregion
            Console.ReadLine();
        }
    }
}