using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Proceduralnie
{

    class Program
    {
        static void Start()
        {
            Console.Clear();
            Console.WriteLine("Aplikacja GRA");
            Console.WriteLine("=============");
            licznik = 0;
            czas = Stopwatch.StartNew();
        }

        static int Losuj()
        {
            Random los = new Random();
            int wylosowana = los.Next(1, 101); // liczby od 1 do 100
#if DEBUG
            Console.WriteLine(wylosowana); // do usunięcia w Release
#endif  
            Console.WriteLine("Wylosowałem liczbę z zakresu od 1 do 100. Odgadnij ją. ");
            return wylosowana;

        }

        static int WczytajPropozycje()
        {
            int propozycja = 0;


            while (true)
            {
                Console.Write("Podaj swoją propozycję: ");
                string napis = Console.ReadLine();
                if (napis == "koniec")
                {
                    throw new ArgumentException("Poddaje się");
                }

                
                try
                {
                    propozycja = int.Parse(napis);
                    break;
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
            }
            licznik++;
            return propozycja;

        }

        static bool Ocena(int wylosowana, int propozycja)
        {
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
                return true;
            }
            return false;
        }


        static void Statystyki()
        {
            czas.Stop();
            Console.WriteLine("Statystyki gry:");
            Console.WriteLine($"- liczba ruchów: {licznik}");
            Console.WriteLine($"- czas gry: {czas.Elapsed}");
        }

        static int licznik = 0;
        static Stopwatch czas;

        static void Main(string[] args)
        {

            Start();
            int x = Losuj();
            bool trafiono;
            do
            {
                int y;
                try
                {
                    // wczytaj propozycję
                    y = WczytajPropozycje();
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("Szkoda, że się poddajesz");
                    return;
                }
                // oceń propozycję
                trafiono = Ocena(x, y);
            }
            while (!trafiono);
            Statystyki();
        }

    }
}