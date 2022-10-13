using System;

namespace PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadanie 2.1
            double F, C = 0.0;
            Console.WriteLine("Podaj temperature w stopniach Celsjusza:");
            C = double.Parse(Console.ReadLine());
            F = 32 + 9.0 / 5 * C;
            Console.WriteLine("Wynik to " + F + " stopni Fahrenheita");

            // zadanie 2.2
            double a, b, c, delta;
            Console.WriteLine("Podaj wspolczynnik a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik c: ");
            c = double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            Console.WriteLine("Delta jest rowna: " + b + "^2 - 4 * " + a + " * " + c + " = " + delta);

            // zadanie 2.3
            double BMI, masa, wzrost;
            Console.WriteLine("Podaj mase w kilogramach: ");
            masa = double.Parse(Console.ReadLine());
            if (masa < 0.0)
            {
                Console.WriteLine("Masa nie moze byc liczba ujemna!");
                Console.WriteLine("Podaj mase: ");
                masa = double.Parse(Console.ReadLine());
            };
            Console.WriteLine("Podaj wzrost w metrach: ");
            wzrost = double.Parse(Console.ReadLine());
            if (wzrost < 0.0)
            {
                Console.WriteLine("Wzrost nie moze byc liczba ujemna!");
                Console.WriteLine("Podaj wzrost: ");
                wzrost = double.Parse(Console.ReadLine());
            };
            BMI = masa / wzrost;
            Console.WriteLine("Twoj wspolczynnik BMI wynosi: " + BMI);

            // zadanie 2.4
            int x0 = 100;
            Console.WriteLine(++x0 * 2);
            // odpowiedź a

            // zadanie 2.5
            int x1 = 2, y1 = 3;
            x1 *= y1 * 2; // 12
            Console.WriteLine(x1);
            // odpowiedź d 

            // zadanie 2.6
            int x2, y2 = 4;
            x2 = (y2 -= 2); // 2
            x2 = y2++; // 2
            x2 = y2--; // 3
            Console.WriteLine(x2); // 3

            // zadanie 2.7
            int x3, y3 = 5;
            x3 = ++y3 * 2; // 12
            x3 = y3++; // 6
            x3 = y3--; // 7
            Console.WriteLine(++y3); // 7

            // zadanie 2.8
            bool x4;
            int y4 = 1, z4 = 1;
            x4 = (y4 == 1 && z4++ == 1);
            Console.WriteLine(x4 + ", " + y4 + ", " + z4);
            // x4 = true, y4 = 1, z4 = 2 
            // odpowiedź a

            // zadanie 2.9
            /*int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z); // false, 2, 4, 2*/

            /*int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z); // false, 2, 5, 2*/

            /*int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z); // false, 2, 5, 1*/

            /*int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z); // true, 1, 3, 4*/

            /*int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z); // true, 1, 4, 4*/

            /*int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z); // true, 1, 4, 5*/

            // zadanie 2.10
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = osoby * 1.0 / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
            // pomnozylem zmienna osoby przez 1.0, dzieki temu typ int zmieni nam sie na double i bedzie widoczna czesc liczby po przecinku
            // bez tego nie jest to mozliwe, poniewaz mnozymy dwie zmienne typu int

            Console.ReadKey();
        }
    }
}