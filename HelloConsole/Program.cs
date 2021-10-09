using System;
using System.Linq;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var random = new Random();
            var zahlen = Enumerable
                .Repeat(0, 10)
                .Select(x => random.Next(0, 101));
            Console.WriteLine($"Glückszahlen {string.Join(", ", zahlen)}");

            Console.WriteLine($"Das Datum: {DateTime.Now.ToShortDateString()}");

            Console.WriteLine("Wie heisst du?");

            var name = Console.ReadLine();

            Console.WriteLine($"Hallo {name}");

            Console.WriteLine("Bitte eine Zahl eingeben?");
            
            var zahlEingabe = Console.ReadLine();
            var zahl = int.Parse(zahlEingabe);
            // zahl = zahl + 7;

            var andereZahl = MultipliziereZahl(zahl, 2);

            Console.WriteLine($"Die Zahl ist {zahl} => {andereZahl}");
            // name = name + zahl.ToString();
            //var nameKopie = name.ToUpper().ToList();
            //nameKopie.Reverse();

            var spiel = new SuperSpielVonGiaminStohlerSchweiz();
            spiel.Start(name);


            // Console.WriteLine($"Hallo {string.Join("", nameKopie)}");

            Console.WriteLine("fertig.");
        }

        private static int MultipliziereZahl(int zahl, int multiplikator)
        {
            var ergebnis = zahl * multiplikator;
            return ergebnis;
        }
    }
}
