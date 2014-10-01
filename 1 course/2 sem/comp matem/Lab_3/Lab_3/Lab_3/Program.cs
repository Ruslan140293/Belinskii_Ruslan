/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_3
{
    class Program
    {
        static void Vivod(List<double> a)
        {
            foreach (double zzz in a)
                Console.WriteLine(zzz);
        }
        static void del(List<double> myList)
        {
            int Countt = 0;
            int j = 0;
            while (j < myList.Count)
            {
                for (int i = 0; i < myList.Count; i++)
                {

                    if (myList[j] == myList[i] && i != j) { Countt++; }

                }
                if (Countt == 0) { myList.Remove(myList[j]); }
                else { Countt = 0; j++; }
            }
            
        }
        static bool prov(string buf)
        {
            bool f = false;
            string[] mas = new string[1];
            mas[0] = buf;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                    if (!char.IsDigit(mas[i][j]))
                        f = true;
            }
            return f;
        }
        static void Main(string[] args)
        {
            List<double> myList = new List<double>();
            string buf = "йцу";
            Console.WriteLine("Введите числа через ентир, для того чтоб закончить введите стоп:)");
            while (buf != "стоп"||buf!="stop")
            {
                buf = Console.ReadLine();
                buf = buf.Trim();
                buf = buf.ToLower();
                if (prov(buf))
                    if (buf == "стоп" || buf == "stop")
                        break;
                else
                {
                    myList.Add(Convert.ToDouble(buf));  
                }
            }
            //ConsoleKeyInfo ex; ex = Console.ReadKey();
            // while (ConsoleKey.Escape != ex.Key){ ex = Console.ReadKey(); }
            //myList.Add("2.34");
            //myList.Add("4.45");
            //myList.Add("4.45");
            //myList.Add("2.34");
            //myList.Add("3.56");
            //myList.Add("4.48");
            //myList.Add("4.43");
            //myList.Add("4.48");
            //myList.Add("4.47");
            //myList.Add("4.48");
            //Vivod(myList);
            del(myList);
            Vivod(myList);
            Console.ReadLine();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Func(List<string> isList, List<string> menList, List<string> bolList, int kol)
        {
            string glas = "а е ё и о у ы э ю я й";
            string[] masGlas = glas.Split(' ');
            char[] simGlas = new char[masGlas.Length];
            for (int i = 0; i < masGlas.Length; i++) { simGlas[i] = masGlas[i][0]; }
            int schetchik = 0;
            for (int i = 0; i < isList.Count; i++)
            {
                for (int j = 0; j < isList[i].Length; j++)
                    for (int k = 0; k < simGlas.Length; k++) if (isList[i][j] == simGlas[k]) schetchik++;
                if (schetchik < kol) { menList.Add(isList[i]); schetchik = 0; }
                else { bolList.Add(isList[i]); schetchik = 0; }
            }
        }
        static void Main(string[] args)
        {
            List<string> isList = new List<string>();
            List<string> menList = new List<string>();
            List<string> bolList = new List<string>();
            string buf = "";
            Console.WriteLine("Введите строки через ентир, когда закончите вводить введите стоп");
            while (buf != "стоп") { buf = Console.ReadLine(); buf = buf.Trim(); buf = buf.ToLower(); if (buf == "стоп")break; isList.Add(buf); }
            Console.WriteLine("Введите количество гласных");
            int kol = Convert.ToInt32(Console.ReadLine());
            Func(isList, menList, bolList, kol);
            Console.WriteLine("меньше " + kol);
            foreach (string zzz in menList) Console.WriteLine(zzz);
            Console.WriteLine("больше " + kol);
            foreach (string zzz in bolList) Console.WriteLine(zzz);
            Console.ReadLine();
        }
    }
}*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> L=new Stack<int>();
            Stack<int> L1 = new Stack<int>();
            Stack<int> L2= new Stack<int>();
            Random r = new Random();
            Console.WriteLine("Заполняем стэки одновременно, нажатие enter приведет к завершению заполнения ");
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("еще?");
                key = Console.ReadKey();
                L1.Push(r.Next(-10, 10)); L2.Push(r.Next(-10, 10));
            }
            while (ConsoleKey.Enter != key.Key);
            Console.WriteLine("1 стэк");
            foreach(int z in L1)
                Console.WriteLine(z);
            Console.WriteLine("2 стэк");
            foreach (int z in L2)
                Console.WriteLine(z);
            int srav = 0;
            for (int i = 0; i < L1.Count; i++)
            {
                for (int j = 0; j < L2.Count; j++) 
                    if (L1.[i] == L2.[j]||L1.[i] == L1.[j]) {break; }
                    else{L.Push(L1.[i]);}
            }
                Console.ReadLine();
        }
    }
}

