using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace mb
{
    class Program
    {
        public static void Vivod(char[,] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(mas[i, j] + " ");
                Console.WriteLine();
            }
        }
        public static void zapol(char[,] playerPole, int n, char[] bukva)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == 0 || i == 11) && (j != 0 && j != 11)) { playerPole[i, j] = bukva[j - 1]; }
                    if ((j == 0 || j == 11) && (i != 0 && i != 11)) { playerPole[i, j] = bukva[i - 1]; /*Convert.ToChar(schetchik); schetchik++;смотреть на обьявление*/ }
                }
            }
        }
        public static void menuRast()
        {
            Console.WriteLine("Нажмите 1 чтобы поставить однопалубный корабль\nНажмите 2 чтоб поставить двухпалубный корабль\nНажмите 3 чтоб поставить трехпалубный корабль\nНажмите 4 чтоб поставить четырех палубный корабль");
        }
        public static bool proverka1(int x, int y, char[,] playerPole)
        {
            if (x < 1 && x > 11 && y < 1 && y > 11) { Console.WriteLine("Вне границ"); return false; }
            if (x == 1 && y == 1) { if (playerPole[x, y + 1] != '\0' || playerPole[x + 1, y] != '\0'||playerPole[x+1,y+1]!='\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x == 10 && y == 1) { if (playerPole[x, y + 1] != '\0' || playerPole[x - 1, y] != '\0'||playerPole[x-1,y+1]!='\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x == 10 && y == 10) { if (playerPole[x, y - 1] != '\0' || playerPole[x - 1, y] != '\0'||playerPole[x-1,y-1]!='\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x == 1 && y == 10) { if (playerPole[x, y - 1] != '\0' || playerPole[x + 1, y] != '\0'||playerPole[x+1,y-1]!='\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x != 1 && y != 1 && x != 10 && y != 10) { if (playerPole[x - 1, y - 1] != '\0' || playerPole[x + 1, y + 1] != '\0' || playerPole[x - 1, y] != '\0' || playerPole[x - 1, y + 1] != '\0' || playerPole[x, y - 1] != '\0' || playerPole[x, y + 1] != '\0' || playerPole[x + 1, y - 1] != '\0' || playerPole[x + 1, y] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x == 1 && (y != 1 && y != 10)) { if (playerPole[x, y + 1] != '\0' || playerPole[x, y - 1] != '\0' || playerPole[x + 1, y] != '\0' || playerPole[x+1, y + 1] != '\0' || playerPole[x+1, y - 1] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x == 10 && (y != 1 && y != 10)) { if (playerPole[x, y + 1] != '\0' || playerPole[x, y - 1] != '\0' || playerPole[x - 1, y] != '\0' || playerPole[x-1, y + 1] != '\0' || playerPole[x-1, y - 1] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (y == 1 && (x != 1 && x != 10)) { if (playerPole[x - 1, y] != '\0' || playerPole[x + 1, y] != '\0' || playerPole[x, y + 1] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (y == 10 && (x != 1 && x != 10)) { if (playerPole[x - 1, y] != '\0' || playerPole[x + 1, y] != '\0' || playerPole[x, y - 1] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            return true;
        }
        public static bool proverka2gor(int x, int y, char[,] playerPole)
        {
            int yarus = 1;
            if (x < 1 && x > 11 && y < 1 && y > 11) { Console.WriteLine("Вне границ"); return false; }
            if (x == 1 && y == 1) { if (playerPole[x, y + 1] != '\0' || playerPole[x + 1, y] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x == 10 && y == 1) { if (playerPole[x, y + 1] != '\0' || playerPole[x - 1, y] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x == 10 && y == 10) { if (playerPole[x, y - 1] != '\0' || playerPole[x - 1, y] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x == 1 && y == 10) { if (playerPole[x, y - 1] != '\0' || playerPole[x + 1, y] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x != 1 && y != 1 && x != 10 && y != 10) { if (playerPole[x - 1, y - 1] != '\0' || playerPole[x + 1, y + 1] != '\0' || playerPole[x - 1, y] != '\0' || playerPole[x - 1, y + 1] != '\0' || playerPole[x, y - 1] != '\0' || playerPole[x, y + 1] != '\0' || playerPole[x + 1, y - 1] != '\0' || playerPole[x + 1, y] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x == 1 && (y != 1 && y != 10)) { if (playerPole[x, y + 1] != '\0' || playerPole[x, y - 1] != '\0' || playerPole[x + 1, y] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (x == 10 && (y != 1 && y != 10)) { if (playerPole[x, y + 1] != '\0' || playerPole[x, y - 1] != '\0' || playerPole[x - 1, y] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (y == 1 && (x != 1 && x != 10)) { if (playerPole[x - 1, y] != '\0' || playerPole[x + 1, y] != '\0' || playerPole[x, y + 1] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            if (y == 10 && (x != 1 && x != 10)) { if (playerPole[x - 1, y] != '\0' || playerPole[x + 1, y] != '\0' || playerPole[x, y - 1] != '\0') { Console.WriteLine("Нельзя"); return false; } }
            return true;
        }
        static void Main(string[] args)
        {
            int n = 12;
            int schetchik1 = 0, schetchik2 = 0, schetchik3 = 0, schetchik4 = 0;
            char[] bukva = { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й' };
            //int schetchik = 0; не правельно конвертирует
            char[,] playerPole = new char[n, n];
            zapol(playerPole, n, bukva);
            char otvet = ' ';
            char otvet2 = ' ';
            bool fl_Zapol = true;
            string sOtvet = "";
            string[] sOtvetMas;
            char[] sep = { ' ' };
            int x = 0, y = 0;
            while ((schetchik1 != 4 || schetchik2 != 3 || schetchik3 != 2 || schetchik4 != 1) && fl_Zapol)
            {
                menuRast();
                otvet = Convert.ToChar(Console.ReadLine());
                switch (otvet)
                {
                    case '1': if (schetchik1 == 4) { Console.WriteLine("Однопалубных достаточно"); break; };
                        Console.WriteLine("Введите координаты через пробел, куда хотите поставить корабль (строка столбец)");
                        Vivod(playerPole, n);
                        sOtvet = Console.ReadLine();
                        sOtvet = sOtvet.Trim(); sOtvet = sOtvet.ToLower(); sOtvetMas = sOtvet.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < sOtvetMas.Length; i++)
                            for (int j = 0; j < bukva.Length; j++)
                            {
                                if (sOtvetMas[i][0] == bukva[j])
                                {
                                    if (i == 0) { x = j + 1; }
                                    if (i == 1) { y = j + 1; }
                                }
                            }
                        if (proverka1(x, y, playerPole)) { playerPole[x, y] = '1'; }
                        else break;
                        schetchik1++;
                        Vivod(playerPole, n);
                        break;
                    case '2': if (schetchik2 == 3) { Console.WriteLine("Двухпалубных достаточно"); break; };
                        Console.WriteLine("Введите координаты через пробел, куда хотите поставить корабль (строка столбец)");
                        Vivod(playerPole, n);
                        sOtvet = Console.ReadLine();
                        sOtvet = sOtvet.Trim(); sOtvet = sOtvet.ToLower(); sOtvetMas = sOtvet.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < sOtvetMas.Length; i++)
                            for (int j = 0; j < bukva.Length; j++)
                            {
                                if (sOtvetMas[i][0] == bukva[j])
                                {
                                    if (i == 0) { x = j + 1; }
                                    if (i == 1) { y = j + 1; }
                                }
                            }
                        Console.WriteLine("Нажмите 1 для горизонтального расположения\nНажмите 2 для вертикального расположения");
                        otvet2 = Convert.ToChar(Console.ReadLine());
                        switch (otvet2)
                        {
                            case '1': break;
                            case '2': break;
                        }
                        schetchik2++;
                        Vivod(playerPole, n);
                        break;
                    case '3': if (schetchik3 == 2) { Console.WriteLine("Трехпалубных достаточно"); break; };
                        Console.WriteLine("Введите координаты через пробел, куда хотите поставить корабль (строка столбец)");
                        Vivod(playerPole, n);
                        sOtvet = Console.ReadLine();
                        sOtvet = sOtvet.Trim(); sOtvet = sOtvet.ToLower(); sOtvetMas = sOtvet.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < sOtvetMas.Length; i++)
                            for (int j = 0; j < bukva.Length; j++)
                            {
                                if (sOtvetMas[i][0] == bukva[j])
                                {
                                    if (i == 0) { x = j + 1; }
                                    if (i == 1) { y = j + 1; }
                                }
                            }


                        schetchik3++;
                        Vivod(playerPole, n);
                        break;
                    case '4':
                        if (schetchik4 == 1) { Console.WriteLine("Четырехпалубных достаточно"); break; };
                        Console.WriteLine("Введите координаты через пробел, куда хотите поставить корабль (строка столбец)");
                        Vivod(playerPole, n);
                        sOtvet = Console.ReadLine();
                        sOtvet = sOtvet.Trim(); sOtvet = sOtvet.ToLower(); sOtvetMas = sOtvet.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < sOtvetMas.Length; i++)
                            for (int j = 0; j < bukva.Length; j++)
                            {
                                if (sOtvetMas[i][0] == bukva[j])
                                {
                                    if (i == 0) { x = j + 1; }
                                    if (i == 1) { y = j + 1; }
                                }
                            }


                        schetchik4++;
                        Vivod(playerPole, n);
                        break;
                    default: fl_Zapol = false; break;
                }
            }
            Vivod(playerPole, n);
            Console.ReadLine();
        }
    }
}
