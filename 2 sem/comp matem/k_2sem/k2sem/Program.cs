using System;

namespace k2sem
{
    class tochka
    {
        private int x;
        private int y;
        private int z;
        public tochka() { x = 0; y = 0; z = 0; }
        public tochka(int chislo)
        {
            Console.WriteLine("x:"); x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y:"); y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("z:"); z = Convert.ToInt32(Console.ReadLine());
        }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int Z { get { return z; } set { z = value; } }
    }
    class OdnMas
    {
        private int size;
        private tochka[] massive;
        public OdnMas()
        {
            size = 10; massive = new tochka[size];
            for (int i = 0; i < massive.Length; i++) { massive[i] = new tochka(); }
        }
        public OdnMas(int ch)
        {
            size = ch; massive = new tochka[size];
            for (int i = 0; i < massive.Length; i++) { massive[i] = new tochka(); }
        }
        public tochka this[int index]
        {
            get
            {
                if (provIndex(index)) return massive[index];
                else { Console.WriteLine("-1"); return null; }
            }
            set
            {
                if (provIndex(index)) massive[index] = value;
                else Console.WriteLine("-1");
            }
        }
        public int Size { get { return size; } set { size = value; } }
        private bool provIndex(int index)
        {
            if (index < size && index >= 0) { return true; }
            else { return false; }
        }
    }
    class Program
    {
        static void menu()
        {
            Console.WriteLine("1 для введения координат");
            Console.WriteLine("2 для изменения координат");
            Console.WriteLine("3 для просмотра координат");
            Console.WriteLine("Введите любой символ для выхода");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            OdnMas mas = new OdnMas(size);
            tochka tchk;
            char otvet;
            int index;
            while (true)
            {
                menu();
                otvet = Convert.ToChar(Console.ReadLine());
                switch (otvet)
                {
                    case '1':
                        Console.WriteLine("Введите индекс:");
                        index = Convert.ToInt32(Console.ReadLine()) - 1;
                        tchk = new tochka(1);
                        mas[index] = tchk;
                        break;
                    case '2':
                        Console.WriteLine("Введите индекс:");
                        index = Convert.ToInt32(Console.ReadLine()) - 1;
                        tchk = new tochka(1);
                        mas[index] = tchk;
                        break;
                    case '3':
                        Console.WriteLine("Введите индекс:");
                        index = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (mas[index] != null)
                        { Console.WriteLine("x=" + mas[index].X + "\ty=" + mas[index].Y + "\tz=" + mas[index].Z); }
                        break;
                    default: return;
                }
            }
        }
    }
}