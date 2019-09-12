using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Monolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Komputer losuje jedną liczbę od 1 do 100
            //////////////////////////////////////////////


            Random los = new Random();
            int wylosowana = los.Next(1, 101); // liczby od 1 do 100
#if DEBUG
            Console.WriteLine(wylosowana); // do usunięcia w Release
#endif  
            Console.WriteLine("Wylosowałem liczbę z zakresu od 1 do 100. Odgadnij ją. ");

            Stopwatch czas = Stopwatch.StartNew();

            bool odgadniete = false; // inicjacja wartownika
            int licznik = 0; // w tym miejscu deklarujemy zmienną licząca liczbę kroków

            do          //  ~~ POWTARZAJ WIELOKROTNIE ~~
            {
                licznik++; // z każdym wykonaniem pętli liczba ruchów zwiększa się o jeden




                // 2. Człowiek proponuje (odgaduje)
                ///////////////////////////////////


                Console.Write("Podaj swoją propozycję: ");
                string napis = Console.ReadLine();
                if (napis == "koniec")
                {
                    Console.WriteLine("Szkoda, że mnie opuszczasz.");
                    return;
                }
                int propozycja = 0;
                try
                {
                    propozycja = int.Parse(napis);
                }
                catch (FormatException) // jeżeli wyłapiesz taki wątek kontynuuj pytanie do skutku
                {
                    Console.WriteLine("Nie podano liczby.\n Spróbuj jeszcze raz");
                    continue;
                }
                catch (OverflowException) // jeżeli wyłapiesz taki wątek kontynuuj pytanie do skutku
                {
                    Console.WriteLine("Przesadziłeś / aś. Za duża liczba.");
                    continue;
                }

                catch (Exception)
                {
                    Console.WriteLine("Niezidentyfikowany wyjątek. Awaria");
                    Environment.Exit(1);
                }

                // 3. Komputer ocenia propozycje
                ////////////////////////////////


                if (propozycja < wylosowana)
                {
                    Console.WriteLine("Za mało");
                }
                else if (propozycja > wylosowana)
                {
                    Console.WriteLine("Za dużo");
                }
                else
                {
                    Console.WriteLine("Trafiłeś");
                    //odgadniete = true; - wartownik, flaga
                    break;
                }
            }
            //while (!odgadniete); // while (propozycja != wylosowana )

            while (true);

            // KONIEC POWTARZAJ

            czas.Stop();

            // 4. Wypisz statystyki gry
            ///////////////////////////


            Console.WriteLine($" - Liczba ruchów: {licznik}");
            Console.WriteLine($" - Czas gry: {czas.Elapsed}");


        }
    }
}
