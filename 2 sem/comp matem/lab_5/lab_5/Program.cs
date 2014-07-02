using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lab_5
{
    class Program
    {
        public struct mobile
        {
            public string name;
            public int chastota;
            public double price;
        }
        static void menu()
        {
            Console.WriteLine("Нажмите 1 для создания базы");
            Console.WriteLine("Нажмите 2 для  дополнения базы");
            Console.WriteLine("Нажмите 3 для изменения базы");
            Console.WriteLine("Нажмите 4 для сортировки");
            Console.WriteLine("Нажмите 5 для просмотра базы");
            Console.WriteLine("Нажмите любую клавишу для выхода");
        }
        static void sozdanie(FileStream aFile)
        {
            String buf = "";
            bool f = true;
            string answer = "";
            char[] charbuf;
            byte[] bytebuf = new byte[50];
            Encoder e = Encoding.UTF8.GetEncoder();
            while (f)
            {
                aFile.Seek(0, SeekOrigin.End);
                Console.WriteLine("Введите название");
                buf = Console.ReadLine() + "\t";
                Console.WriteLine("Введите частоту");
                buf += Console.ReadLine() + "\t";
                Console.WriteLine("Введите цену");
                buf += Console.ReadLine() + "\t";
                charbuf = buf.ToCharArray();
                e.GetBytes(charbuf, 0, charbuf.Length, bytebuf, 0, true);
                aFile.Write(bytebuf, 0, 50);
                Array.Clear(charbuf, 0, charbuf.Length);
                Array.Clear(bytebuf, 0, bytebuf.Length);
                Console.WriteLine("Еще?");
                answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "yes" || answer == "y" || answer == "да" || answer == "д") f = true;
                else f = false;
            }
        }
        static void sozdanie(FileStream aFile, int n)
        {
            String buf = "";
            char[] charbuf;
            byte[] bytebuf = new byte[50];
            Encoder e = Encoding.UTF8.GetEncoder();
            Console.WriteLine("Введите название");
            buf = Console.ReadLine() + "\t";
            Console.WriteLine("Введите частоту");
            buf += Console.ReadLine() + "\t";
            Console.WriteLine("Введите цену");
            buf += Console.ReadLine() + "\t";
            charbuf = buf.ToCharArray();
            e.GetBytes(charbuf, 0, charbuf.Length, bytebuf, 0, true);
            aFile.Seek(50 * n - 50, SeekOrigin.Begin);
            aFile.Write(bytebuf, 0, 50);
        }
        static void izmen(FileStream aFile)
        {
            vivod(aFile);
            byte[] bytebuf = new byte[50];
            int kol = 0;
            aFile.Seek(0, SeekOrigin.Begin);
            while (aFile.Read(bytebuf, 0, bytebuf.Length) != 0)
            {
                kol++;
            }
            int n;
            do
            {
                Console.WriteLine("Введите какую позицию менять:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 0 || n > kol);
            sozdanie(aFile, n);
        }
        static void sort(FileStream aFile)
        {
            int k;
            do
            {
                Console.WriteLine("Введите по какому столбику сортировать:");
                k = Convert.ToInt32(Console.ReadLine()) - 1;
            }
            while (k > 2 || k < 0);
            Encoder e = Encoding.UTF8.GetEncoder();
            Decoder d = Encoding.UTF8.GetDecoder();
            char[] charbuf = new char[50];
            byte[] bytebuf = new byte[50];
            aFile.Seek(0, SeekOrigin.Begin);
            string buf = "";
            char[] sep = { '\t' };
            string[] mas1 = new string[4];
            int kol = 0;
            int kolSt = 0;
            mobile[] baza = new mobile[3];
            while (aFile.Read(bytebuf, 0, bytebuf.Length) != 0)
            {
                kol = 0;
                buf = "";
                while (kol < 2)
                {
                    d.GetChars(bytebuf, 0, bytebuf.Length, charbuf, 0, true);
                    for (int i = 0; i < charbuf.Length; i++)
                    {
                        buf += charbuf[i];
                    }
                    Array.Clear(bytebuf, 0, 50);
                    Array.Clear(charbuf, 0, 50);
                    mas1 = buf.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    if (mas1.Length != 3 && mas1.Length != 4) break;
                    baza[kol].name = mas1[0];
                    baza[kol].chastota = Convert.ToInt32(mas1[1]);
                    baza[kol].price = Convert.ToDouble(mas1[2]);
                    Array.Clear(mas1, 0, mas1.Length);
                    buf = ""; kol++;
                    if (kol != 2) aFile.Read(bytebuf, 0, bytebuf.Length);
                }
                if (k == 0)
                {
                    for (int i = 0; i < kol - 1; i++)
                    {
                        for (int j = 0; j < kol - i - 1; j++)
                        {
                            if ((baza[j].name.CompareTo(baza[j + 1].name)) == 1)
                            {
                                baza[2] = baza[j];
                                baza[j] = baza[j + 1];
                                baza[j + 1] = baza[2];
                                aFile.Seek(kolSt * 50, SeekOrigin.Begin);
                                Array.Clear(charbuf, 0, 50);
                                Array.Clear(bytebuf, 0, 50);
                                for (int g = 0; g < kol; g++)
                                {
                                    if (g == 1) aFile.Seek(kolSt * 50 + 50, SeekOrigin.Begin);
                                    buf = baza[g].name + '\t' + baza[g].chastota + '\t' + baza[g].price;
                                    charbuf = buf.ToCharArray();
                                    e.GetBytes(charbuf, 0, charbuf.Length, bytebuf, 0, true);
                                    charbuf = new char[50];
                                    aFile.Write(bytebuf, 0, 50);
                                    Array.Clear(charbuf, 0, 50);
                                    Array.Clear(bytebuf, 0, 50);
                                }
                                kolSt=0;
                                aFile.Seek(kolSt * 50, SeekOrigin.Begin);
                            }
                            else
                            {
                                kolSt++;
                                aFile.Seek(kolSt * 50, SeekOrigin.Begin);
                            }
                        }
                    }
                }
                if (k == 1)
                {

                    for (int i = 0; i < kol - 1; i++)
                        for (int j = 0; j < kol - i - 1; j++)
                            if (baza[j].chastota > baza[j + 1].chastota)
                            {
                                baza[2] = baza[j];
                                baza[j] = baza[j + 1];
                                baza[j + 1] = baza[2];
                                aFile.Seek(kolSt * 50, SeekOrigin.Begin);
                                Array.Clear(charbuf, 0, 50);
                                Array.Clear(bytebuf, 0, 50);
                                for (int g = 0; g < kol; g++)
                                {
                                    if (g == 1) aFile.Seek(kolSt * 50 + 50, SeekOrigin.Begin);
                                    buf = baza[g].name + '\t' + baza[g].chastota + '\t' + baza[g].price;
                                    charbuf = buf.ToCharArray();
                                    e.GetBytes(charbuf, 0, charbuf.Length, bytebuf, 0, true);
                                    charbuf = new char[50];
                                    aFile.Write(bytebuf, 0, 50);
                                    Array.Clear(charbuf, 0, 50);
                                    Array.Clear(bytebuf, 0, 50);
                                }
                                kolSt=0;
                                aFile.Seek(kolSt * 50, SeekOrigin.Begin);
                            }
                            else
                            {
                                kolSt++;
                                aFile.Seek(kolSt * 50, SeekOrigin.Begin);
                            }
                }
                if (k == 2)
                {
                    for (int i = 0; i < kol - 1; i++)
                        for (int j = 0; j < kol - i - 1; j++)
                            if (baza[j].price > baza[j + 1].price)
                            {
                                baza[2] = baza[j];
                                baza[j] = baza[j + 1];
                                baza[j + 1] = baza[2];
                                aFile.Seek(kolSt * 50, SeekOrigin.Begin);
                                Array.Clear(charbuf, 0, 50);
                                Array.Clear(bytebuf, 0, 50);
                                for (int g = 0; g < kol; g++)
                                {
                                    if (g == 1) aFile.Seek(kolSt * 50 + 50, SeekOrigin.Begin);
                                    buf = baza[g].name + '\t' + baza[g].chastota + '\t' + baza[g].price;
                                    charbuf = buf.ToCharArray();
                                    e.GetBytes(charbuf, 0, charbuf.Length, bytebuf, 0, true);
                                    charbuf = new char[50];
                                    aFile.Write(bytebuf, 0, 50);
                                    Array.Clear(charbuf, 0, 50);
                                    Array.Clear(bytebuf, 0, 50);
                                }
                                kolSt = 0;
                                aFile.Seek(kolSt * 50, SeekOrigin.Begin);
                            }
                            else
                            {
                                kolSt++;
                                aFile.Seek(kolSt * 50, SeekOrigin.Begin);
                            }
                }
            }
            vivod(aFile);
        }
        static void vivod(FileStream aFile)
        {
            Decoder d = Encoding.UTF8.GetDecoder();
            char[] charbuf = new char[50];
            byte[] bytebuf = new byte[50];
            aFile.Seek(0, SeekOrigin.Begin);
            while (aFile.Read(bytebuf, 0, bytebuf.Length) != 0)
            {
                d.GetChars(bytebuf, 0, bytebuf.Length, charbuf, 0);
                Console.WriteLine(charbuf);
                Array.Clear(bytebuf, 0, 50);
            }
        }
        static void Main(string[] args)
        {

            FileStream aFile = new FileStream("baza.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Char chose_menu;
            while (true)
            {
                menu();
                chose_menu = Convert.ToChar(Console.ReadLine());
                switch (chose_menu)
                {
                    case '1':
                        {
                            aFile.Close();
                            FileInfo af = new FileInfo("baza.txt");
                            af.Delete();
                            aFile = new FileStream("baza.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            sozdanie(aFile);
                            break;
                        }
                    case '2': { sozdanie(aFile); break; }
                    case '3': { izmen(aFile); break; }
                    case '4': { sort(aFile); break; }
                    case '5': { vivod(aFile); break; }
                    default: { aFile.Close(); return; }
                }
            }
        }
    }
}