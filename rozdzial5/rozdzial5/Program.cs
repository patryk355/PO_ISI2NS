using System;

namespace Rozdzial5
{
    class Program
    {
        // 5.1
        static double zamienStopnie(double stopnie)
        {
            double stopnieCelsjusza = (stopnie - 32) * 5.0 / 9.0;
            return stopnieCelsjusza;
        }
        static bool czyNalezyDoPrzedzialu(double a, double b, double x)
        {
            bool odp;

            if (x > a && x < b)
            {
                odp = true;
            } else
            {
                odp = false;
            }

            return odp;
        }
        // 5.3
        static void Przesun(double x, double y)
        {
            double[] wek = { 3, 2 };
            double newX = wek[0] + x;
            double newY = wek[1] + y;
            Console.Write(newX + ", " + newY);
        }
        static void Pomnoz(int[] tab, int mnoznik)
        {
            int[] tab2 = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                tab2[i] = tab[i] * mnoznik;
            }
            for (int i = 0; i < tab2.Length; i++)
            {
                Console.Write(tab2[i] + " ");
            }
        }
        // 5.5
        static void Rysuj(int dlugosc, int szerokosc, char znak)
        {
            string wiersz;
            for (int i = 0; i < dlugosc; i++)
            {
                wiersz = "";
                for (int j = 0; j < szerokosc; j++)
                {
                    wiersz += znak;
                }
                Console.WriteLine(wiersz);
            }

        }
        // 5.7
        static void ObliczWyrazenie(int x, int n)
        {
            if (x < 0 || n < 0)
            {
                Console.WriteLine("liczby musza byc naturalne");
                return;
            }
            int wynik = 0, tmp = 1;

            for (int i = 0; i < n; i++)
            {
                wynik += x + tmp;
                tmp++;
            }

            Console.WriteLine("Wynik wyrazenia to: {0}", wynik);
        }
        // 5.8
        static void ObliczSumeCyfr(int liczba)
        {
            int wynik = 0;
            string tmp = liczba.ToString();
            for (int i = 0; i < tmp.Length; i++)
            {
                wynik += int.Parse(tmp[i].ToString());
            }
            Console.WriteLine("Suma cyfr liczby {0} wynosi {1}", liczba, wynik);
        }
        // 5.9
        static int CiagFibonacciego(int n)
        {
            if ((n==1) || (n==2)) return 1;
            else return CiagFibonacciego(n-1)+CiagFibonacciego(n-2);
        }
        static int Oblicz(int n)
        {
            if (n <= 1) return (1);
            else return (n + Oblicz(n - 1));
        }
        static void Main(string[] args)
        {
            // 5.1
            double stopnie = zamienStopnie(140);
            Console.WriteLine(stopnie);

            // 5.2
            bool czyNalezy = czyNalezyDoPrzedzialu(2, 8, 5);
            Console.WriteLine(czyNalezy);

            // 5.3
            double x, y;
            Console.WriteLine("podaj wsp x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj wsp y");
            y = double.Parse(Console.ReadLine());
            Przesun(x, y);

            // 5.4
            int[] tab = { 1, 4, 6, 8, 2 };
            Pomnoz(tab, 2);

            // 5.5
            int dlugosc, szerokosc;
            char znak;
            Console.WriteLine("podaj dlugosc prostokata");
            dlugosc = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj szerokosc prostokata");
            szerokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj znak prostokata");
            znak = char.Parse(Console.ReadLine());
            Rysuj(dlugosc, szerokosc, znak);

            // 5.7
            int liczbaX, liczbaN;
            Console.WriteLine("Podaj liczbe naturalna x");
            liczbaX = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe naturalna n");
            liczbaN = int.Parse(Console.ReadLine());
            ObliczWyrazenie(liczbaX, liczbaN);

            // 5.8
            int liczba8;
            Console.WriteLine("podaj liczbe calkowita");
            liczba8 = int.Parse(Console.ReadLine());
            ObliczSumeCyfr(liczba8);

            // 5.9
            int n;
            Console.WriteLine("Podaj n");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("n nie moze byc ujemne!");
                return;
            }
            Console.WriteLine("{0}-ty wyraz ciagu Fibonacciego wynosi: {1}", n, CiagFibonacciego(n));

            // 5.10
            int wynik10 = Oblicz(5);
            Console.WriteLine(wynik10);

            Console.ReadKey();
        }
    }
}
