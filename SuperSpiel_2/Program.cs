using System;
using System.Linq;

namespace SuperSpiel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo");
            Console.WriteLine("wie ist dein name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Lust auf ein Spiel {name}?");

            // - Spiel Titel
            Console.WriteLine("          DAS LOTTOSPIEL        ");

            // - Zufallszahlen
            var random = new Random();
            var zahlen = Enumerable
                .Repeat(0, 6)
                .Select(x => random.Next(0, 101))
                .ToList();
            Console.WriteLine($"Lottozahlen sind {string.Join(", ", zahlen)}");
            var random2 = new Random();
            var zahlIndex = random.Next(0, zahlen.Count());
            var gesuchteZahl = zahlen.ElementAt(zahlIndex);

            var Versuche = 3;

            while (Versuche > 0)
            {
                Console.WriteLine($"schreibe eine dieser zahlen auf.Versuch:{Versuche}/0");
                var ausgewählteZahl = Console.ReadLine();

                if (int.TryParse(ausgewählteZahl, out var zahl) && zahl == gesuchteZahl) 
                {
                    Console.WriteLine("YOU WIN");
                    return;
                }
                else
                {
                    Console.WriteLine("Try again");
                    Versuche--;
                }
            }
            Console.WriteLine("Keine Versuche übrig");
            Console.WriteLine("YOU LOSE");
            Console.WriteLine($"richtige Lösung: {gesuchteZahl}");
        }
    }
}
