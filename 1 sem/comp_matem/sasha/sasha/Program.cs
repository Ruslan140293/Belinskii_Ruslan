using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba_2
{
    class Program
    {
        static public void Metod_Gayssa()
        {
            int N = Convert.ToInt32(Console.ReadLine()); //размер массива

            double[,] A = new double[N, N];


            double detA, k, buf;

            int max, j, z = 0, p, s, zam, c = 0, r;

            max = 1; //максимальный элемент в первой строке

            detA = 1; //Определитель

            zam = 0; // Число замен
            for (c = 0; c < N; c++)
                for (r = 0; r < N; r++)
                {

                    A[c, r] = Convert.ToInt32(Console.ReadLine()); //Считываем массив

                }

            for (c = 0; c < N - 2; c++)
            {
                for (z = 0; z < N - 2; z++)
                {
                    max = z;
                }

                for (j = z + 2; j < N; j++)
                {
                    if ((Math.Abs(A[c, j])) > (Math.Abs(A[c, max]))) //Выбор главного элемента
                        max = j;
                }
            }
            //перестановка строк
            for (p = 0; p < N; p++)
            {
                buf = A[p, z]; A[p, z] = A[p, max]; buf = A[p, max];
            }

            for (r = c; r < N; r++)
            {
                k = A[c, r] / A[c, c];

                for (s = 0; s < N; s++)
                    A[s, r] = A[s, r] - A[s, c] * k;
            }

            if (c != max)
            {
                zam++;
            }

            for (c = 0; c < N; c++)
            {
                detA = detA * A[c, c];

                if (zam % 2 != 0)

                    detA = (-1) * detA;

            }

            Console.WriteLine(detA);
        }



        static void Main(string[] args)
        {
            Metod_Gayssa();
            Console.ReadLine();
        }
    }

}