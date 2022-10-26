using System;

namespace Rozdzial4
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadanie 4.1
            /*int n;
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
            }*/

            // zadanie 4.2
            /*int[] tab1 = { -5, 0, 2, 4, 11, -81, -17, 2, 3, 99};
            int[] tab2 = new int[10];
            int idx = 0;
            foreach(int el in tab1)
            {
                if (el > 0)
                {
                    tab2[idx] = el;
                    idx++;
                }   
            }

            foreach(int el in tab2)
            {
                Console.WriteLine(el);
            }*/

            // zadanie 4.3
            /*int rozmiar;
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
            Console.WriteLine("Liczba dodatnich elementow to {0}", liczbaDodatnich);*/

            // zadanie 4.4
            /*int iloscLiczbPierwszych = 0;
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
            Console.WriteLine("Ilosc liczb pierwszych w tej tablicy wynosi: {0}", iloscLiczbPierwszych);*/

            // zadanie 4.5
            /*int roz5;
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
                tab5copy[i] = tab5[i-1];
            }
            tab5copy[0] = tab5[tab5.Length - 1];
            Console.WriteLine("tab5copy:");
            for (int i = 0; i < tab5copy.Length; i++)
            {
                Console.WriteLine(tab5copy[i]);
            }*/

            // zadanie 4.6
            /*double[,] tab6 = { { 1.4, 2.2 }, { 3.0, 4.1 }, { -5.62, 6.725 }, { 7.0, 8.1 }, { -9.1, 10.2 } };
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
            Console.WriteLine("Suma elementow na przekatnej wynosi: ", sumaNaPrzekatnej);*/

            // zadanie 4.7

            // zadanie 4.8
            /*string[,] dniTygodnia;
            dniTygodnia = new string[7, 3];  
            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[2, 0] = "sroda";
            dniTygodnia[3, 0] = "czwartek";
            dniTygodnia[4, 0] = "piatek";
            dniTygodnia[5, 0] = "sobota";
            dniTygodnia[6, 0] = "niedziela";

            dniTygodnia[0, 1] = "monday";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[2, 1] = "wednesday";
            dniTygodnia[3, 1] = "thursday";
            dniTygodnia[4, 1] = "friday";
            dniTygodnia[5, 1] = "saturday";
            dniTygodnia[6, 1] = "sunday";

            dniTygodnia[0, 2] = "montag";
            dniTygodnia[1, 2] = "dienstag";
            dniTygodnia[2, 2] = "mittwoch";
            dniTygodnia[3, 2] = "donnerstag";
            dniTygodnia[4, 2] = "freitag";
            dniTygodnia[5, 2] = "samstag";
            dniTygodnia[6, 2] = "sonntag";
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("{0,1}",dniTygodnia[i,j]);
                }
            }*/

            // zadanie 4.9
            /*string tekst1;
            Console.WriteLine("Wprowadz tekst");
            tekst1 = Console.ReadLine();
            int iloscWyrazow = 0;
            string[] tab9;
            tab9 = tekst1.Split();
            iloscWyrazow = tab9.Length;
            Console.WriteLine("Liczba wyrazow w tekscie to: {0}", iloscWyrazow);*/

            // zadanie 4.10
            /*string data;
            Console.WriteLine("Podaj date w formacie DD-MM-RRRR");
            data = Console.ReadLine();
            string[] miesiace = { "styczen", "luty", "marzec", "kwiecien", "maj", "czerwiec","lipiec", "sierpien", "wrzesien", "pazdziernik", "listopad", "grudzien" };
            string miesiac = data.Substring(3, 2);
            Console.WriteLine(miesiace[int.Parse(miesiac)-1]);*/

            // zadanie 4.11
            /*string tekst2;
            Console.WriteLine("podaj tekst");
            tekst2 = Console.ReadLine();
            if (tekst2 == null) return;
            for (int i = 0; i < tekst2.Length; i++)
            {
                int licznik = 0;
                for (int j = 0; j < tekst2.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    } else
                    {
                        if (tekst2[i] == tekst2[j])
                        {
                            licznik++;
                        }
                    }
                }
                licznik++;
                Console.WriteLine("{0} wystepuje {1} razy", tekst2[i], licznik);
            }*/

            // zadanie 4.12
            
            // zadanie 4.13

            // zadanie 4.14

            // zadanie 4.15


            Console.ReadKey();
        }
    }
}