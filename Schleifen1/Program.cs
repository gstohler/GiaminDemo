using System;
using System.Collections.Generic;
using System.Threading;

namespace Schleifen1
{
    class Program
    {
        static void Main(string[] args)
        {
            var punkte = 0;
            Console.WriteLine("Hallo Spieler.Wie ist dein Benutzername?");
            var benutzername = Console.ReadLine();
            Console.WriteLine($"Ok, {benutzername} starten wir!");
            Console.WriteLine("Schreibe alles was ich sage auf");
            Console.WriteLine("  ");
            Thread.Sleep(TimeSpan.FromSeconds(1.5));
            var TexteZumAbschreiben = new List<string>
            {
                "Das hast",
                "du gut",
                "gemacht,",
                "weil du",
                "etwas richtig",
                "gelöst hast.",
                "also",
                "gebe",
                "dir immer",
                "so viel",
                "Mühe,",
                "dann wirst du einmal richtig gut!"
            };
            foreach (var einText in TexteZumAbschreiben)
            {
                Console.WriteLine($"Text: {einText}");
                var eingabe = Console.ReadLine();
                if (eingabe == einText)
                {
                    // punkte +
                    punkte += 5;
                }
                else
                {
                    // punkte -
                    punkte -= 5;

                }
                Console.WriteLine($"Deine Punkte {punkte}");
                Console.WriteLine("Weiter geht's");
                Console.WriteLine("  ");
                Thread.Sleep(TimeSpan.FromSeconds(1.5));
            }
            Console.WriteLine("Oder doch nicht");
            Console.WriteLine("Fertig");
        }
    }
}