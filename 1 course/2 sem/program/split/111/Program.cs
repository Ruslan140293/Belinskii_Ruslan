using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _111
{
    class Program
    {
        static void Main(string[] args)
        {
            string buf1 = "", buf2 = "";
            Console.WriteLine("Введите строку");
            string st = Console.ReadLine();
            st=st.Trim();
            for (int i = 0; i < st.Length-1; i++)
            {
                if (st[i] == ' ' && st[i + 1] == ' ')
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        buf1 += Convert.ToString(st[j]);
                    }
                    for (int j = i + 2; j < st.Length; j++)
                    {
                        buf2 += Convert.ToString(st[j]);
                    }
                    st = buf1 + buf2;
                    buf1 = ""; buf2 = "";
                }
            }
            Console.WriteLine(st);
            Console.ReadLine();
        }
    }
}
