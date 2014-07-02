using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practic
{
    class figura
    {
        protected char ch;
        protected int x;
        protected int y;
        public figura()
        {
            ch = '*';
            x = 0;
            y = 0;
        }

        public char CH { get { return ch; } set { ch = value; } }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        virtual public void draw() { }
    }

    class glaza : figura
    {
       
    }
    class golova : figura
    {
        public override void draw()
        {
            Console.CursorTop = x;
            Console.CursorLeft = y;
            for (int i = 0; i < 25; i++)
                Console.WriteLine(ch);
        }
    }
    class lapi : figura
    {
        public lapi() { }

        override public void draw()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            figura ris = new golova();
            ris.draw();
            Console.ReadLine();
        }
    }
}
