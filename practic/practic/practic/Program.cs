using System;

namespace practic
{
    class figura
    {
        protected char ch;
        protected int x;
        protected int y;
        public figura()
        {
            x = 0;
            y = 0;
            ch = '*';
        }

        public figura(int a, int b)
        {
            x = a;
            y = b;
        }
        public char CH { get { return ch; } set { ch = value; } }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        virtual public void draw() { }
    }
    class glaza : figura
    {
        public glaza(int a, int b)
        {
            x = a;
            y = b;
        }
        private int h = 2;
        public override void draw()
        {//glaza ll
            Console.CursorLeft = x + 2;
            Console.CursorTop = y;
            for (int i = 0; i < h; i++)
            {
                Console.WriteLine(ch);
                Console.CursorLeft = x + 2;
            }//glaza lt
            Console.CursorLeft = x + 3;
            Console.CursorTop = y;
            for (int i = 0; i < h; i++)
            {
                Console.Write(ch);
            }//glaza rl
            Console.CursorLeft = x + 8;
            Console.CursorTop = y;
            for (int i = 0; i < h; i++)
            {
                Console.WriteLine(ch);
                Console.CursorLeft = x + 2;
            }//glaza rt
            Console.CursorLeft = x + 9;
            Console.CursorTop = y;
            for (int i = 0; i < h; i++)
            {
                Console.Write(ch);
            }//gl
            Console.CursorLeft = x + 3;
            Console.CursorTop = y + 1;
            Console.WriteLine("'");//gr
            Console.CursorLeft = x + 9;
            Console.CursorTop = y + 1;
            Console.WriteLine("'");
        }
    }
    class golova : figura
    {
        public golova(int a, int b)
        {
            x = a;
            y = b;
        }
        private int wTop = 5, w = 3, wRot = 7, wDown = 8, s = 1;
        public override void draw()
        {
            //romb lt
            Console.CursorLeft = x;
            Console.CursorTop = y + 3;
            for (int i = 0; i < w; i++)
            {
                Console.Write(ch);
                Console.CursorTop = y + 3 - s;
                s++;
            }
            s = 1;//romb ld
            Console.CursorLeft = x;
            Console.CursorTop = y + 3;
            for (int i = 0; i < w; i++)
            {
                Console.Write(ch);
                Console.CursorTop = y + 3 + s;
                s++;
            }
            Console.CursorLeft = x + 10;
            Console.CursorTop = y + 1;
            s = 1;//romb rt
            for (int i = 0; i < w; i++)
            {
                Console.Write(ch);
                Console.CursorTop = y + 1 + s;
                s++;
            }//romb rd
            Console.CursorLeft = x + 12;
            Console.CursorTop = y + 3;
            s = 1;
            for (int i = 0; i < w; i++)
            {
                Console.Write(ch);
                Console.CursorTop = y + 3 + s;
                Console.CursorLeft = x + 12 - s;
                s++;
            }// golova top
            Console.CursorLeft = x + 4;
            Console.CursorTop = y + 1;
            for (int i = 0; i < wTop; i++)
                Console.Write(ch);
            //rot
            Console.CursorLeft = x + 3;
            Console.CursorTop = y + 3;
            for (int i = 0; i < wRot; i++)
                Console.Write(ch);
            // nozdrya l
            Console.CursorLeft = x + 5;
            Console.CursorTop = y + 2;
            Console.WriteLine(ch);
            //nozdrya r
            Console.CursorLeft = x + 7;
            Console.CursorTop = y + 2;
            Console.WriteLine(ch);
            //telo d
            Console.CursorLeft = x + 2;
            Console.CursorTop = y + 12;
            for (int i = 0; i < wDown; i++)
            {
                Console.Write(ch);
            }
        }
    }
    class lapi : figura
    {
        public lapi(int a, int b)
        {
            x = a;
            y = b;
        }
        private int h1 = 7, h2 = 9, w = 3, s = 1;
        override public void draw()
        {//left up
            Console.CursorLeft = x + 0;
            Console.CursorTop = y + 7;
            for (int i = 0; i < w; i++)
            {
                Console.Write(ch);
                Console.CursorTop = y + 7 - s;
                s++;
            }//left l
            Console.CursorLeft = x;
            Console.CursorTop = y + 7;
            for (int i = 0; i < h1; i++)
            {
                Console.WriteLine(ch);
                Console.CursorLeft = x;
            }
            s = 0;
            //Left r
            for (int i = 0; i < h2; i++)
            {
                Console.CursorLeft = x + 2;
                Console.CursorTop = y + 5 + s;
                Console.Write(ch);
                s++;
            }//left d
            Console.CursorLeft = x;
            Console.CursorTop = y + 13;
            for (int i = 0; i < w; i++)
                Console.Write(ch);
            s = 1;//right up
            Console.CursorLeft = x + 10;
            Console.CursorTop = y + 5;
            for (int i = 0; i < w; i++)
            {
                Console.Write(ch);
                Console.CursorTop = y + 5 + s;
                s++;
            }//right r
            Console.CursorLeft = x + 12;
            Console.CursorTop = y + 7;
            for (int i = 0; i < h1; i++)
            {
                Console.WriteLine(ch);
                Console.CursorLeft = x + 12;
            }
            s = 0;// right l
            for (int i = 0; i < h2; i++)
            {
                Console.CursorLeft = x + 10;
                Console.CursorTop = y + 5 + s;
                Console.Write(ch);
                s++;
            }//right d
            Console.CursorLeft = x + 10;
            Console.CursorTop = y + 13;
            for (int i = 0; i < w; i++)
                Console.Write(ch);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int x = 0, y = 0;
            while (flag)
            {
                Console.WriteLine("Введите координату Х:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату Y:");
                y = Convert.ToInt32(Console.ReadLine());
                if ((x > -1 && x < 67) && (y > -1 && y < 286))
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Не влазит");
                }
            }
            figura[] ris = new figura[3];
            ris[0] = new golova(x, y);
            ris[1] = new lapi(x, y);
            ris[2] = new glaza(x, y);
            Console.Clear();
            for (int i = 0; i < ris.Length; i++)
            {
                ris[i].draw();
            }
            Console.ReadLine();
        }
    }
}
