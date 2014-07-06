using System;

namespace practic
{
    class figura
    {
        protected char ch;
        protected int x;
        protected int y;
        protected int mashtab;
        public figura()
        {
            x = 0;
            y = 0;
            ch = '*';
            mashtab = 1;
        }

        public figura(int a, int b, char c, int mash)
        {
            x = a;
            y = b;
            ch = c;
            mashtab = mash;
        }
        public int MASHTAB { get { return mashtab; } set { mashtab = value; } }
        public char CH { get { return ch; } set { ch = value; } }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        virtual public void draw() { }
    }
    class glaza : figura
    {
        public glaza(int a, int b, char c, int mash) : base(a, b, c, mash) { }
        private int h = 2, h1 = 3;

        public override void draw()
        {//glaza ll
            h *= mashtab; h1 *= mashtab;
            Console.CursorLeft = (x + 2) * mashtab;
            Console.CursorTop = y * mashtab;
            for (int i = 0; i < h; i++)
            {
                Console.WriteLine(ch);
                Console.CursorLeft = (x + 2) * mashtab;
            }//glaza lt
            Console.CursorLeft = (x + 2) * mashtab;
            Console.CursorTop = y * mashtab;
            for (int i = 0; i < h1; i++)
            {
                Console.Write(ch);
            }
            Console.CursorLeft = (x + 4) * mashtab;
            Console.CursorTop = y * mashtab;
            for (int i = 0; i < h; i++)
            {
                Console.WriteLine(ch);
                Console.CursorLeft = (x + 4) * mashtab;
            }
            Console.CursorLeft = (x + 3) * mashtab;
            Console.CursorTop = (y + 1) * mashtab;
            Console.WriteLine("'");
        }
    }
    class golova : figura
    {
        public golova(int a, int b, char c, int mash) : base(a, b, c, mash) { }
        private int wTop = 5, w = 3, wRot = 7, wDown = 8, s = 1;
        public override void draw()
        {
            wTop *= mashtab; w *= mashtab; wRot *= mashtab; wDown *= mashtab;
            //romb lt
            Console.CursorLeft =x*mashtab;
            Console.CursorTop = (y + 3) * mashtab;
            for (int i = 0; i < w; i++)
            {
                Console.Write(ch);
                Console.CursorTop = ((y + 3) * mashtab) - s;
                s++;
            }
            s = 1;//romb ld
            Console.CursorLeft = x*mashtab;
            Console.CursorTop = (y + 3) * mashtab;
            for (int i = 0; i < w; i++)
            {
                Console.Write(ch);
                Console.CursorTop = ((y + 3) * mashtab) + s;
                s++;
            }
            Console.CursorLeft = (x + 10) * mashtab;
            Console.CursorTop = (y + 1) * mashtab;
            s = 1;//romb rt
            for (int i = 0; i < w; i++)
            {
                Console.Write(ch);
                Console.CursorTop = ((y + 1) * mashtab) + s;
                s++;
            }//romb rd
            Console.CursorLeft = (x + 12) * mashtab;
            Console.CursorTop = (y + 3) * mashtab;
            s = 1;
            for (int i = 0; i < w; i++)
            {
                Console.Write(ch);
                Console.CursorTop = ((y + 3) * mashtab) + s;
                Console.CursorLeft = ((x + 12) * mashtab) - s;
                s++;
            }// golova top
            Console.CursorLeft = (x + 4) * mashtab;
            Console.CursorTop = (y + 1) * mashtab;
            for (int i = 0; i < wTop; i++)
                Console.Write(ch);
            //rot
            Console.CursorLeft = (x + 3) * mashtab;
            Console.CursorTop = (y + 3) * mashtab;
            for (int i = 0; i < wRot; i++)
                Console.Write(ch);
            // nozdrya l
            Console.CursorLeft = (x + 5) * mashtab;
            Console.CursorTop = (y + 2) * mashtab;
            Console.WriteLine(ch);
            //nozdrya r
            Console.CursorLeft = (x + 7) * mashtab;
            Console.CursorTop = (y + 2) * mashtab;
            Console.WriteLine(ch);
            //telo d
            Console.CursorLeft = (x + 2) * mashtab;
            Console.CursorTop = (y + 12) * mashtab;
            for (int i = 0; i < wDown; i++)
            {
                Console.Write(ch);
            }
        }
    }
    class lapi : figura
    {
        protected bool flag = true;
        public bool FLAG { get { return flag; } set { flag = value; } }
        public lapi(int a, int b, char c, bool fl, int mash) : base(a, b, c, mash) { flag = fl; }
        private int h1 = 7, h2 = 9, w = 3, s = 1;
        override public void draw()
        {
            h1 *= mashtab; h2 *= mashtab; w *= mashtab;
            //left up
            if (flag)
            {
                Console.CursorLeft = x*mashtab;
                Console.CursorTop = (y + 7) * mashtab;
                for (int i = 0; i < w; i++)
                {
                    Console.Write(ch);
                    Console.CursorTop = ((y + 7) * mashtab) - s;
                    s++;
                }//left l
                Console.CursorLeft = x*mashtab;
                Console.CursorTop = (y + 7) * mashtab;
                for (int i = 0; i < h1; i++)
                {
                    Console.WriteLine(ch);
                    Console.CursorLeft = x*mashtab;
                }
                s = 0;
                //Left r
                for (int i = 0; i < h2; i++)
                {
                    Console.CursorLeft = (x + 2) * mashtab;
                    Console.CursorTop = ((y + 5) * mashtab) + s;
                    Console.Write(ch);
                    s++;
                }//left d
                Console.CursorLeft = x*mashtab;
                Console.CursorTop = (y + 13) * mashtab;
                for (int i = 0; i < w; i++)
                    Console.Write(ch);
                s = 1;
            }
            else
            {//right up
                Console.CursorLeft = (x + 10) * mashtab;
                Console.CursorTop = (y + 5) * mashtab;
                for (int i = 0; i < w; i++)
                {
                    Console.Write(ch);
                    Console.CursorTop = ((y + 5) * mashtab) + s;
                    s++;
                }//right r
                Console.CursorLeft = (x + 12) * mashtab;
                Console.CursorTop = (y + 7) * mashtab;
                for (int i = 0; i < h1; i++)
                {
                    Console.WriteLine(ch);
                    Console.CursorLeft = (x + 12) * mashtab;
                }
                s = 0;// right l
                for (int i = 0; i < h2; i++)
                {
                    Console.CursorLeft = (x + 10) * mashtab;
                    Console.CursorTop = ((y + 5) * mashtab) + s;
                    Console.Write(ch);
                    s++;
                }//right d
                Console.CursorLeft = (x + 10) * mashtab;
                Console.CursorTop = (y + 13) * mashtab;
                for (int i = 0; i < w; i++)
                    Console.Write(ch);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int mash = 1;
            bool flag = true;
            int x = 0, y = 0;
            while (flag)
            {
                Console.WriteLine("Введите координату X:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату Y:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите масштаб:");
                mash = Convert.ToInt32(Console.ReadLine());
                if ((x * mash > -1 && x * mash < 67) && (y * mash > -1 && y * mash < 286))
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Не влазит");
                }
            }
            Console.WriteLine("Введите символ:");
            char ch = Convert.ToChar(Console.ReadLine());
            figura[] ris = new figura[5];
            ris[0] = new golova(x, y, ch, mash);
            ris[1] = new lapi(x, y, ch, true, mash);
            ris[2] = new lapi(x, y, ch, false, mash);
            ris[3] = new glaza(x, y, ch, mash);
            ris[4] = new glaza(x + 6, y, ch, mash);
            Console.Clear();
            for (int i = 0; i < ris.Length; i++)
            {
                ris[i].draw();
            }
            Console.ReadLine();
        }
    }
}
