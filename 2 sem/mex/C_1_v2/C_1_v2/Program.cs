using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_1_v2
{
    class Program
    {
        static double a, b, c, F, q, Q, M, alfa, Xa, Ya, Ra, Rb, Ra_min, alfa_min;
        static void Reaction(double alfa)
        {
            double cos = Math.Cos(alfa * Math.PI / 180.0),
            sin = Math.Sin(alfa * Math.PI / 180.0);
            Xa = F * cos;
            Rb = -(1.0 / (a + c)) * (Q * (b / 2.0 - a) - M - F * sin * 2.0 * a);
            Ya = Q + F * sin - Rb;
            Ra = Math.Sqrt(Xa*Xa+ Ya*Ya);
        }
        static void RA_min()
        {
            Ra_min = 1.0E20;
            for (int i = 0; i < 360; i += 5)
            {
                Reaction((double)i);
                if (Ra_min > Ra)
                {
                    Ra_min = Ra;
                    alfa_min = i;
                }
            }
        }
        static void Main(string[] args)
        {

            a = 1.0; b = 3.0; c = 2.0; F = 25.0; q = 3.0; Q = q * b; M = 7.0; alfa = 30;
            Reaction(alfa);
            Console.WriteLine("Xa={0:F5}", Xa);
            Console.WriteLine("Ya={0:F5}", Ya);
            Console.WriteLine("Ra={0:F5}", Ra);
            Console.WriteLine("Rb={0:F5}", Rb);
            RA_min();
            Console.WriteLine("Ra_min={0:F5}", Ra_min);
            Console.WriteLine("alfa*={0}", alfa_min);
            Console.ReadLine();
        }
    }
}
