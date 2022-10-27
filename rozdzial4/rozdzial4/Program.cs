using System;

namespace Rozdzial4
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadanie 4.1
            int n;
            Console.WriteLine("Podaj rozmiar tablicy: ");
            n = int.Parse(Console.ReadLine());
            double[] tab = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("podaj liczbe");
                tab[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Wartosci w tablicy: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tab[i]);
            }

            // zadanie 4.2
            int[] tab1 = { -5, 0, 2, 4, 11, -81, -17, 2, 3, 99 };
            int[] tab2 = new int[10];
            int idx = 0;
            foreach (int el in tab1)
            {
                if (el > 0)
                {
                    tab2[idx] = el;
                    idx++;
                }
            }

            foreach (int el in tab2)
            {
                Console.WriteLine(el);
            }

            // zadanie 4.3
            int rozmiar;
            Console.WriteLine("podaj rozmiar");
            rozmiar = int.Parse(Console.ReadLine());
            int[] tab3 = new int[rozmiar];
            for (int i = 0; i < tab3.Length; i++)
            {
                Console.WriteLine("podaj liczbe");
                tab3[i] = int.Parse(Console.ReadLine());
            }
            int najwieksza = tab3[0], najmniejsza = tab3[0], liczbaDodatnich = 0;
            double srednia = 0.0;

            for (int i = 0; i < tab3.Length; i++)
            {
                if (tab3[i] > najwieksza)
                {
                    najwieksza = tab3[i];
                }
                if (tab3[i] < najmniejsza)
                {
                    najmniejsza = tab3[i];
                }
                if (tab3[i] > 0)
                {
                    liczbaDodatnich++;
                }
                srednia += tab3[i];
            }

            srednia /= rozmiar;

            Console.WriteLine("Najwieksza wartosc to {0}", najwieksza);
            Console.WriteLine("Najmniejsza wartosc to {0}", najmniejsza);
            Console.WriteLine("Srednia wartosci elementow to {0}", srednia);
            Console.WriteLine("Liczba dodatnich elementow to {0}", liczbaDodatnich);

            // zadanie 4.4
            int iloscLiczbPierwszych = 0;
            Random rand = new Random();
            int[] tab4 = new int[100];
            for (int i = 0; i < tab4.Length; i++)
            {
                tab4[i] = rand.Next(1, 1000);
            }

            for (int i = 0; i < tab4.Length; i++)
            {
                Console.WriteLine(tab4[i]);
            }

            foreach (int el in tab4)
            {
                int licznik = 0;
                for (int i = 1; i <= el; i++)
                {
                    if (el % i == 0)
                    {
                        licznik++;
                    }
                }
                if (licznik == 2)
                {
                    iloscLiczbPierwszych++;
                }
            }
            Console.WriteLine("Ilosc liczb pierwszych w tej tablicy wynosi: {0}", iloscLiczbPierwszych);

            // zadanie 4.5
            int roz5;
            Console.WriteLine("Podaj rozmiar tablicy");
            roz5 = int.Parse(Console.ReadLine());
            int[] tab5 = new int[roz5];
            int[] tab5copy = new int[roz5];
            for (int i = 0; i < tab5.Length; i++)
            {
                Console.WriteLine("Podaj liczbe");
                tab5[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < tab5.Length; i++)
            {
                tab5copy[i] = tab5[i - 1];
            }
            tab5copy[0] = tab5[tab5.Length - 1];
            Console.WriteLine("tab5copy:");
            for (int i = 0; i < tab5copy.Length; i++)
            {
                Console.WriteLine(tab5copy[i]);
            }

            // zadanie 4.6
            double[,] tab6 = new double[5, 5] {
                { 1.4, 2.2, 1.4, 2.2, 2.1 },
                { 1.4, 2.2, 1.4, 2.2, 2.1 },
                { 1.4, 2.2, 1.4, 2.2, 2.1 },
                { 1.4, 2.2, 1.4, 2.2, 2.1 },
                { 1.4, 2.2, 1.4, 2.2, 2.1 }
            };
            double sumaNaPrzekatnej = 0;

            for (int i = 0; i < tab6.GetLength(0); i++)
            {
                for (int j = 0; j < tab6.GetLength(1); j++)
                {
                    Console.WriteLine(tab6[i, j]);
                    if (i == j)
                    {
                        sumaNaPrzekatnej += tab6[i, j];
                    }
                }
            }
            Console.WriteLine("Suma elementow na przekatnej wynosi: {0}", sumaNaPrzekatnej);

            // zadanie 4.7
            int[,] macierzA = new int[2, 3] { { 2, 4, 5 }, { 5, 6, 1 } };
            int[,] macierzB = new int[2, 3] { { -5, 11, 2 }, { 7, 2, -1 } };
            int[,] macierzWynikowa = new int[2, 3];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    macierzWynikowa[i, j] = macierzA[i, j] + macierzB[i, j];

            Console.WriteLine("Macierz wynikowa wynosi: ");
            for (int i = 0; i < 2; i++)
            {
                string line = "";
                for (int j = 0; j < 3; j++)
                {
                    line += macierzWynikowa[i, j] + " ";
                }
                Console.WriteLine(line);
            }

            // zadanie 4.8
            string[,] dniTygodnia = new string[7, 3]
            {
                { "poniedzialek", "monday", "montag" },
                { "wtorek", "tuesday", "dienstag" },
                { "sroda", "wednesday", "mittwoch" },
                { "czwartek", "thursday", "donnerstag" },
                { "piatek", "friday", "freitag" },
                { "sobota", "saturday", "samstag" },
                { "niedziela", "sunday", "sonntag" },
            };

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0,1} ", dniTygodnia[i, j]);
                Console.WriteLine("\n");
            }

            // zadanie 4.9
            string tekst1;
            int iloscWyrazow = 0;
            string[] tab9;
            Console.WriteLine("Wprowadz tekst");
            tekst1 = Console.ReadLine();
            tab9 = tekst1.Split();
            iloscWyrazow = tab9.Length;
            Console.WriteLine("Liczba wyrazow w tekscie to: {0}", iloscWyrazow);

            // zadanie 4.10
            string data;
            Console.WriteLine("Podaj date w formacie DD-MM-RRRR");
            data = Console.ReadLine();
            string[] miesiace = { "styczen", "luty", "marzec", "kwiecien", "maj", "czerwiec", "lipiec", "sierpien", "wrzesien", "pazdziernik", "listopad", "grudzien" };
            string miesiac = data.Substring(3, 2);
            Console.WriteLine(miesiace[int.Parse(miesiac) - 1]);

            Console.ReadKey();
        }
    }
}