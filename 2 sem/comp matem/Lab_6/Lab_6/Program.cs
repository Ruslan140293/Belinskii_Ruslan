using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lab_6
{
    class bankomat
    {
        Random r = new Random();
        private int iin_bankomat;
        private int ost;
        private int min_snyatie;
        private int max_snyatie;
        private int max_zagr;
        public int Iin_bankomat { get { return iin_bankomat; } }
        public int Ost { get { return ost; } }
        public int Min_snyatie
        {
            get { return min_snyatie; }
            set { min_snyatie = value; }
        }
        public int Max_snyatie
        {
            get { return max_snyatie; }
            set { max_snyatie = value; }
        }
        public int Max_zagr { get { return max_zagr; } }
        public bankomat()
        {
            iin_bankomat = r.Next(0, 1000);
            ost = 0;
            min_snyatie = 50;
            max_snyatie = 4000;
            max_zagr = 10000;
        }
        public bankomat(int min, int max)
        {
            iin_bankomat = r.Next(0, 1000);
            ost = 0;
            min_snyatie = min;
            max_snyatie = max;
            max_zagr = 10000;
        }
        public int zagruzka(int zag)
        {
            if (zag > max_zagr || ost + zag > max_zagr)
            { Console.WriteLine("errore"); return 0; }
            return ost += zag;
        }
        public int snyatie(int s)
        {
            if ((s >= min_snyatie && s <= max_snyatie) && ost > s)
                return ost -= s;
            else
            { Console.WriteLine("errore"); return 0; }
        }
        public void ost_sum()
        {
            Console.WriteLine(ost);
        }
        public void zapis()
        {
            StreamWriter sw = new StreamWriter("Log.txt", true);
            sw.WriteLine("ИИН банкомата:{0}\r\nОстаток:{1}\r\nМинимальное снятие:{2}\r\nМаксимальное снятие:{3}\r\nМаксимальная загрузка:{4}", iin_bankomat, ost, min_snyatie, max_snyatie, max_zagr);
            sw.Close();
        }
    }
    class Program
    {
        static void menu()
        {
            Console.WriteLine("Нажмите 1 для загрузки денег в банкомат");
            Console.WriteLine("Нажмите 2 для снятие денег с банкомата");
            Console.WriteLine("Нажмите 3 для того чтобы увидеть остаток");
            Console.WriteLine("Введите любой символ чтобы выйти");
        }
        static void menuList()
        {
            Console.WriteLine("Нажмите 1 чтобы создать банкомат");
            Console.WriteLine("Нажмите 2 чтобы удалить банкомат");
            Console.WriteLine("нажмите 3 чтобы работать с банкоматом");
            Console.WriteLine("Введите любой символ чтобы выйти");
        }
        static void Main(string[] args)
        {
            bool fl = true;
            int n = 0;
            bankomat bank = new bankomat();
            char otvet = ' ';
            List<bankomat> bankomaty = new List<bankomat>();
            while (1 == 1)
            {
                menuList();
                otvet = Convert.ToChar(Console.ReadLine());
                switch (otvet)
                {
                    case '1':
                        {
                            Console.WriteLine("Введите минимальное снятие:");
                            string sMin = Console.ReadLine();
                            Console.WriteLine("Введите максимальное снятие:");
                            string sMax = Console.ReadLine();
                            sMin = sMin.Trim(); sMax = sMax.Trim();
                            if (sMin.Length == 0 && sMax.Length == 0)
                            {
                                bank = new bankomat();
                            }
                            else
                            {
                                int min = Convert.ToInt32(sMin); int max = Convert.ToInt32(sMax); bank = new bankomat(min, max);
                            }
                            while (fl)
                            {
                                menu();
                                otvet = Convert.ToChar(Console.ReadLine());
                                switch (otvet)
                                {
                                    case '1':
                                        Console.WriteLine("Введите сумму для зарузки:");
                                        int zag = Convert.ToInt32(Console.ReadLine());
                                        bank.zagruzka(zag);
                                        break;
                                    case '2':
                                        Console.WriteLine("Введите сумму для снятия:");
                                        int s = Convert.ToInt32(Console.ReadLine());
                                        bank.snyatie(s);
                                        break;
                                    case '3': bank.ost_sum(); break;
                                    default: fl = false; break;
                                }//switch in
                            }//while in
                            fl = true;
                            bankomaty.Add(bank);
                            break;
                        }//case
                    case '2':
                        {
                            if (bankomaty.Count == 0) { Console.WriteLine("Нечего удалять)))"); break; }
                            Console.WriteLine("Введите номер банкомата который хотите удалить:");
                            n = Convert.ToInt32(Console.ReadLine());
                            bank = bankomaty[n - 1];
                            bankomaty.Remove(bank);
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine("Введите номер банкомата с которым хотите работать:");
                            n = Convert.ToInt32(Console.ReadLine());
                            if (n > bankomaty.Count) { Console.WriteLine("Нет такого))) их всего {0}", bankomaty.Count); break; }
                            while (fl)
                            {
                                menu();
                                otvet = Convert.ToChar(Console.ReadLine());
                                switch (otvet)
                                {
                                    case '1':
                                        Console.WriteLine("Введите сумму для зарузки:");
                                        int zag = Convert.ToInt32(Console.ReadLine());
                                        bankomaty[n - 1].zagruzka(zag);
                                        break;
                                    case '2':
                                        Console.WriteLine("Введите сумму для снятия:");
                                        int s = Convert.ToInt32(Console.ReadLine());
                                        bankomaty[n - 1].snyatie(s);
                                        break;
                                    case '3': bankomaty[n - 1].ost_sum(); break;
                                    default: fl = false; break;
                                }//switch in
                            }//while in
                            fl = true;
                            break;
                        }
                    default:
                        {
                            for (int i = 0; i < bankomaty.Count; i++)
                            {
                                StreamWriter sw = new StreamWriter("Log.txt", true);
                                sw.WriteLine("Банкомат №:" + (i + 1));
                                sw.Close();
                                bankomaty[i].zapis();
                            }
                            return;
                        }
                }
            }
        }
    }
}
