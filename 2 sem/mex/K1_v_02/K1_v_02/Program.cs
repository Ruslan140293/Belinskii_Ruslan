using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K1_v_02
{
    class Program
    {
        static double a = 1.5;
        static double b = -3.0;
        static double c = 2.3;
        static double d = 2.0;
        static double k = 4.0;
        static double t = 0;
        static double t1 = 1.2;
        static void tabl() { for (double i = t; i < 2.5; i += 0.3) { Console.WriteLine(@"{0:F2}  {1:F2}", x(i), y(i)); } }
        static double x(double t) { return a + (b *( Math.Cos((Math.PI * t )/ k))); }
        static double y(double t) { return c + (d *( Math.Sin((Math.PI * t) / k))); }
        static double Vx(double t) { return ((-b * Math.Sin(Math.PI * t / k)) *( Math.PI / k)); }
        static double Vy(double t) { return ((d * Math.Cos(Math.PI * t / k)) * (Math.PI / k)); }
        static double V(double t) { return Math.Sqrt((Vx(t1) * Vx(t1)) + (Vy(t1) * Vy(t1))); }
        static double Wx(double t) { return ((-b * Math.Cos((Math.PI * t) / k)) * ((Math.PI * Math.PI) / (k * k))); }
        static double Wy(double t) { return ((-d * Math.Sin(Math.PI * t / k)) * ((Math.PI * Math.PI )/ (k * k))); }
        static double W(double t) { return Math.Sqrt((Wx(t) * Wx(t)) + (Wy(t) * Wy(t))); }
        static double Wt(double t) { return (((Vx(t) * Wx(t)) + (Vy(t) * Wy(t)))) / V(t); }
        static double Wn(double t) { return (Math.Sqrt((W(t) * W(t)) - (Wt(t) * Wt(t)))); }
        static double ro(double t) { return ((V(t) * V(t)) / Wn(t)); }
        static void Main(string[] args)
        {
            Console.WriteLine("Х={0:F3}", x(t));
            Console.WriteLine("Y={0:F3}", y(t));
            Console.WriteLine("Х1={0:F3}", x(t1));
            Console.WriteLine("Y1={0:F3}", y(t1));
            Console.WriteLine("Vx={0:F3}", Vx(t1));
            Console.WriteLine("Vy={0:F3}", Vy(t1));
            Console.WriteLine("|V|={0:F3}", V(t1));
            Console.WriteLine("Wx={0:F3}", Wx(t1));
            Console.WriteLine("Wy={0:F3}", Wy(t1));
            Console.WriteLine("|W|={0:F3}", W(t1));
            Console.WriteLine("Wt={0:F3}",Wt(t1));
            Console.WriteLine("Wn={0:F3}",Wn(t1));
            Console.WriteLine("Ро={0:F3}",ro(t1));
            Console.WriteLine();
            tabl();
            Console.ReadLine();
        }
    }
}
