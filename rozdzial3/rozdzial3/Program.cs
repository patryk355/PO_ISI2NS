using System;

namespace Rozdzial3
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadanie 3.1
            /*int year;
            Console.WriteLine("Podaj rok: ");
            year = int.Parse(Console.ReadLine());
            if (year < 0)
            {
                Console.WriteLine("Rok nie moze byc liczba ujemna");
                return;
            }
            if (year % 4 == 0 && year % 100 != 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("Rok nie jest przestepny");

                } else
                {
                    Console.WriteLine("Rok jest przestępny");
                }
            } else
            {
                Console.WriteLine("Rok nie jest przestepny");
            }*/

            // zadanie 3.2
            /*int a, b;
            Console.WriteLine("Podaj liczbe calkowita: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe calkowita: ");
            b = int.Parse(Console.ReadLine());

            if (a % b == 0) 
            { 
                Console.WriteLine("Liczba {0} jest dzielnikiem liczby {1}", b, a);
            } else
            {
                Console.WriteLine("Liczba {0} nie jest dzielnikiem liczby {1}", b, a);
            }*/

            // zadanie 3.3
            /*double num1, num2, num3, tmp;
            Console.WriteLine("Podaj liczbe");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe");
            num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3) tmp = num1;
            else if (num2 > num1 && num2 > num3) tmp = num2;
            else if (num3 > num1 && num3 > num2) tmp = num3;
            else tmp = num1;

            Console.WriteLine("Najwieksza z podanych liczb to: {0}", tmp);*/

            // zadanie 3.4
            /*double value1, value2, score = 0.0;
            Console.WriteLine("Podaj liczbe: ");
            value1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            value2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak operacji: ");
            char type = char.Parse(Console.ReadLine()); 
            
            switch (type)
            {
                case '+':
                    score = value1 + value2;
                    break;
                case '-':
                    score = value1 - value2;
                    break;
                case '*':
                    score = value1 * value2;
                    break;
                case '/':
                    if (value2 == 0)
                    {
                        Console.WriteLine("Nie mozna dzielic przez 0!");
                    } else
                    {
                        score = value1 / value2;
                    }
                    break;
                default:
                    Console.WriteLine("Podano zly znak operacji. Dostepne znaki: +, -, /, *");
                    break;
            }
            Console.WriteLine("Wynik to: {0}", score);*/

            // zadanie 3.5
            /*double delta, wspA, wspB, wspC;
            Console.WriteLine("Podaj wspolczynnik a: ");
            wspA = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik b: ");
            wspB = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik c: ");
            wspC = double.Parse(Console.ReadLine());

            delta = wspB * wspB - 4 * wspA * wspC;
            if (delta > 0) Console.WriteLine("Rownanie ma dwa pierwiastki");
            else if (delta == 0) Console.WriteLine("Rownanie ma jeden pierwiastek");
            else Console.WriteLine("Rownanie nie ma pierwiastkow");*/

            // zadanie 3.6
            /*double masa, wzrost, BMI = 0.0;
            Console.WriteLine("Podaj mase w kg");
            masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach");
            wzrost = double.Parse(Console.ReadLine());
            BMI = masa / (wzrost * wzrost);
            string kat;
            if (BMI < 18.5)
            {   
                if (BMI < 16.0) kat = "wyglodzenie";
                else if (BMI >= 16.0 && BMI < 16.99) kat = "wychudzenie";
                else kat = "niedowaga";
                Console.WriteLine("Niedowaga, kategoria: {0}", kat);
            }
            else if (BMI >= 18.5 && BMI < 24.99)
            {
                Console.WriteLine("Wartosc prawidlowa, pozadana masa ciala");
            }
            else
            {
                if (BMI >= 25.0 && BMI <= 29.99) kat = "nadwaga";
                else if (BMI >= 30.0 && BMI <= 34.99) kat = "otylosc I stopnia";
                else if (BMI >= 35.0 && BMI < 39.99) kat = "otylosc II stopnia";
                else kat = "otylosc III stopnia";
                Console.WriteLine("Nadwaga, kategoria: {0}", kat);
            }*/

            // zadanie 3.7
            /*Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();
            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;
                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;
            }*/

            // zadanie 3.8
            /*double srednia;
            Console.WriteLine("Podaj średnią: ");
            srednia = double.Parse(Console.ReadLine());
            if (srednia >= 2.00 && srednia <= 3.99)
            {
                Console.WriteLine("Wysokosc stypendium to: 0.00zl");
            } 
            else if (srednia >= 4.00 && srednia <= 4.79)
            {
                Console.WriteLine("Wysokosc stypendium to: 350.00zl");
            } 
            else if (srednia >= 4.80 && srednia <= 5.00)
            {
                Console.WriteLine("Wysokosc stypendium to: 550.00zl");
            } 
            else
            {
                Console.WriteLine("Podano złą średnią");
            }*/

            // zadanie 3.9
            /*char wariant;
            string figura = "";
            Console.WriteLine("Wybierz wariant a, b, c lub d");
            wariant = char.Parse(Console.ReadLine());
            switch (wariant)
            {
                case 'a':
                    figura = "*\n**\n***\n****";
                    break;
                case 'b':
                    figura = "****\n***\n**\n*";
                    break;
                case 'c':
                    figura = "   *\n  **\n ***\n****";
                    break;
                case 'd':
                    figura = "  ****\n  *  *\n  *  *\n  ****";
                    break;
            }
            Console.WriteLine(figura);*/

            // zadanie 3.10
            /*int n, wynik = 1;
            Console.WriteLine("Podaj dodatnia liczbe calkowita n: ");
            n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                for (int i = 1; i <= n; i++) wynik *= i;
            }
            else if (n == 0) wynik = 1;
            else {
                Console.WriteLine("Liczba nie moze byc ujemna");
                return;
            }

            Console.WriteLine("{0}! = {1}", n, wynik);*/

            // zadanie 3.11
            /*int iloscLiczb = 0, sumaLiczb = 0, liczba = 1; ;
            while (sumaLiczb <= 100)
            {
                sumaLiczb += liczba;
                iloscLiczb++;
                liczba++;
            }
            Console.WriteLine("Aby suma przekroczyla wartosc 100 nalezy dodac do siebie {0} kolejnych liczb calkowitych", iloscLiczb);*/

            // zadanie 3.12
            /*int calkowita = 1;
            while (calkowita != 0)
            {
                Console.WriteLine("Podaj liczbe calkowita: ");
                calkowita = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Koniec programu, poniewaz podano 0");*/

            // zadanie 3.13
            /*int naturalna = 0, sumaSzeregu = 0;
            Console.WriteLine("Podaj liczbe naturalna n: ");
            naturalna = int.Parse(Console.ReadLine());

            if (naturalna <= 0) return;

            for (int i = 1; i <= naturalna; i++)
            {
                if (i % 2 == 0) sumaSzeregu -= i; 
                else sumaSzeregu += i;
            }
            Console.WriteLine("Suma szeregu wynosi {0}", sumaSzeregu);*/

            // zadanie 3.14
            /*int number = 1, podzielnik = 1, sumaPodzielnikow = 0;
            Console.WriteLine("Podaj liczbe: ");
            number = int.Parse(Console.ReadLine());

            while (podzielnik <= number)
            {
                if (podzielnik >= 1 && podzielnik < number)
                {
                    if (number % podzielnik == 0) sumaPodzielnikow += podzielnik;
                }
                podzielnik++;
            }
            if (sumaPodzielnikow == number) Console.WriteLine("{0} jest liczba doskonala", number);
            else Console.WriteLine("{0} nie jest liczba doskonala", number);*/
           
            Console.ReadKey();
        }
    }
}
