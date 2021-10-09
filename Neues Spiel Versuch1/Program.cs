using System;
using System.Collections.Generic;
using System.Threading;

namespace Neues_Spiel_Versuch1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Spieler.Wie ist dein Benutzername?");
            var benutzername = Console.ReadLine();
            Console.WriteLine($"Ok, {benutzername} starten wir!");
            var punkte = 0;
            var abschreiben1 = "Das hast";
            Console.WriteLine("Schreibe alles was ich sage auf(Ausser die\"\")");
            Console.WriteLine("Let's Start");
            Console.WriteLine("  ");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine("\"Das hast\"");
            var antwort1 = Console.ReadLine(); 
            if (antwort1 == abschreiben1)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine bisherigen Punkte {punkte}");
            Console.WriteLine("Weiter");
            Console.WriteLine("  ");
            var abschreiben2 = "du gut";
            Console.WriteLine("\"du gut\""); 
            var antwort2 = Console.ReadLine();
            if (antwort2 == abschreiben2)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine bisherigen Punkte {punkte}");
            var abschreiben3 = "gemacht,";
            Console.WriteLine("Weiter");
            Console.WriteLine("  ");
            Console.WriteLine("\"gemacht,\"");
            var antwort3 = Console.ReadLine();
            if (antwort3 == abschreiben3)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine bisherigen Punkte {punkte}");
            var abschreiben4 = "weil du";
            Console.WriteLine("Weiter");
            Console.WriteLine("  ");
            Console.WriteLine("\"weil du\"");
            var antwort4 = Console.ReadLine();
            if (antwort4 == abschreiben4)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine bisherigen Punkte {punkte}");
            var abschreiben5 = "etwas richtig";
            Console.WriteLine("Weiter");
            Console.WriteLine("  ");
            Console.WriteLine("\"etwas richtig\"");
            var antwort5 = Console.ReadLine();
            if (antwort5 == abschreiben5)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine bisherigen Punkte {punkte}");
            var abschreiben6 = "gelöst hast.";
            Console.WriteLine("Weiter");
            Console.WriteLine("  ");
            Console.WriteLine("\"gelöst hast.\"");
            var antwort6 = Console.ReadLine();
            if (antwort6 == abschreiben6)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine bisherigen Punkte {punkte}");
            var abschreiben7 = "Also";
            Console.WriteLine("Weiter");
            Console.WriteLine("  ");
            Console.WriteLine("\"Also\"");
            var antwort7 = Console.ReadLine();
            if (antwort7 == abschreiben7)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine bisherigen Punkte {punkte}");
            var abschreiben8 = "gebe";
            Console.WriteLine("Weiter");
            Console.WriteLine("  ");
            Console.WriteLine("\"gebe\"");
            var antwort8 = Console.ReadLine();
            if (antwort8 == abschreiben8)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine bisherigen Punkte {punkte}");
            var abschreiben9 = "dir immer";
            Console.WriteLine("Weiter");
            Console.WriteLine("  ");
            Console.WriteLine("\"dir immer\"");
            var antwort9 = Console.ReadLine();
            if (antwort9 == abschreiben9)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine bisherigen Punkte {punkte}");
            var abschreiben10 = "so viel";
            Console.WriteLine("Weiter");
            Console.WriteLine("  ");
            Console.WriteLine("\"so viel\"");
            var antwort10 = Console.ReadLine();
            if (antwort10 == abschreiben10)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine bisherigen Punkte {punkte}");
            var abschreiben11 = "Mühe,";
            Console.WriteLine("Weiter");
            Console.WriteLine("  ");
            Console.WriteLine("\"Mühe,\"");
            var antwort11 = Console.ReadLine();
            if (antwort11 == abschreiben11)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine bisherigen Punkte {punkte}");
            var abschreiben12 = "dann wirst du einmal richtig gut!";
            Console.WriteLine("Weiter");
            Console.WriteLine("  ");
            Console.WriteLine("\"dann wirst du einmal richtig gut!\"");
            var antwort12 = Console.ReadLine();
            if (antwort12 == abschreiben12)
            {
                punkte += 5;
            }
            else
            {
                punkte -= 5;
            }
            Console.WriteLine($"Deine Punkte insgesamt {punkte}");
        }
    }
}