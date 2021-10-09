using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    class SuperSpielVonGiaminStohlerSchweiz
    {
        public void Start(string name)
        {
            var minZahl = 1;
            var maxZahl = 101;
            var maxAnzahlVersuche = 10;

            // - zufallszahl generieren
            var random = new Random();
            var gesuchteZahl = random.Next(minZahl, maxZahl);

            // - benutzer gibt eigene zahl ein
            var anzahlVersuche = 0;
            while(anzahlVersuche < maxAnzahlVersuche)
            {
                Console.WriteLine($"#{anzahlVersuche+1}/{maxAnzahlVersuche} | {name}, bitte eine Zahl eingeben von {minZahl} bis {maxZahl-1}?");
                
                var zahlEingabe = Console.ReadLine();

                if(int.TryParse(zahlEingabe, out var zahl))
                {
                    // - program gibt an, ob grösser oder kleiner
                    if (zahl == gesuchteZahl)
                    {
                        // - wenn zahl gefunden, fertig
                        Console.WriteLine("Richtig!");
                        return;
                    }
                    if (zahl < gesuchteZahl)
                    {
                        Console.WriteLine("zu klein");
                    }
                    else
                    {
                        Console.WriteLine("zu gross");
                    }
                    anzahlVersuche++;
                }
                else
                {
                    Console.WriteLine("ungültig, nochmals!");
                }
            }
            Console.WriteLine("Zu viele Versuche!");
            Console.WriteLine($"Lösung {gesuchteZahl}");
        }
    }
}
