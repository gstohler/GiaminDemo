using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versuch_1_Mastermind
{
    class Spiel
    {
        // - Liste der Zahlen
        private readonly List<string> _zahlen = new List<string>
            {
                "1",
                "2",
                "3",
                "4"
            };

        public void Play()
        {
            SchreibNachricht(" Hallo ");
            Console.WriteLine("Zahlen:      1,   2,   3,   4");

            var richtigerCode = MachNeuenGeheimCode();
            SchreibNachricht($"DEMO: {richtigerCode}");

            // - 10 mal
            // - User gibt code ein (4 stellen, 1-4)
            // - code prüfen
            //   - alle exakt => user gewinnt, programm fertig
            //   - sonst
            //     - ausgabe wie viel richtige zahl und position
            //     - ausgabe wie viel richtige zahl
            // - nach 10 versuchen
            //   - geheimcode anzeigen, 
            //   - you loose 

            // - Eingaben + Versuche
            var versuche = 0;
            var maxversuche = 10;

            while (versuche < maxversuche)
            {
                Console.WriteLine($"Versuch #{versuche + 1}/{maxversuche}");
                var antwortCode = LeseAntwortCode();

                // code prüfen
                if (antwortCode.IsCodeGleichWie(richtigerCode))
                {
                    GewinnerNachrichtZeigen();
                    return;
                }

                // - Überprüfung(Zahl und Ort)
                var richtigeZahlUndOrt = antwortCode.BerechneRichtigeZahlUndRichtigerOrt(richtigerCode);
                SchreibNachricht($"==> Richtige Zahlen mit richtiger Position: {richtigeZahlUndOrt}", false);

                var richtigeZahlen = Code.BerechneRichtigeZahlenInAntwort(richtigerCode, antwortCode);
                SchreibNachricht($"==> Richtige Zahlen: {richtigeZahlen}", false);

                versuche++;
            }

            Console.WriteLine("Keine Versuche übrig");
            Console.WriteLine("YOU LOOSE");
            Console.WriteLine($"Richtiger Code: {richtigerCode}");

            //var demoCode = MachNeuenGeheimCode();

            //if(richtigerCode.IsCodeGleichWie(demoCode))
            //{
            //    // was für ein zufall
            //    int x = 0;
            //}

            //var test1 = richtigerCode.IsCodeGleichWie(richtigerCode);
            //var test2 = demoCode.IsCodeGleichWie(demoCode);





            /*
            while (versuche < maxversuche)
            {
                var Zahl1 = Console.ReadLine();
                var Zahl2 = Console.ReadLine();
                var Zahl3 = Console.ReadLine();
                var Zahl4 = Console.ReadLine();
                var antwort = $"{Zahl1}{Zahl2}{Zahl3}{Zahl4}";

                if (richtigercode == antwort)
                {
                    Console.WriteLine("YOU WIN");
                    return;
                }
                else
                {
                    Console.WriteLine("FAlSE");

                    versuche++;

                    var richtigezahlundOrt = 0;

                    // - ????Überprüfung(Zahl und Ort)
                    if (Zahl1 == geheimZahl1)
                    {
                        richtigezahlundOrt++;
                    }
                    if (Zahl2 == geheimZahl2)
                    {
                        richtigezahlundOrt++;
                    }
                    if (Zahl3 == geheimZahl3)
                    {
                        richtigezahlundOrt++;
                    }
                    if (Zahl4 == geheimZahl4)
                    {
                        richtigezahlundOrt++;
                    }
                    // - ????Noch nicht Vollständig)
                    // -Überprüfung(Zahlen)
                    var richtigezahlen = 0;
                    if (antwort.Contains(geheimZahl1))
                    {
                        richtigezahlen++;
                    }
                    if (antwort.Contains(geheimZahl2))
                    {
                        richtigezahlen++;
                    }
                    if (antwort.Contains(geheimZahl3))
                    {
                        richtigezahlen++;
                    }
                    if (antwort.Contains(geheimZahl4))
                    {
                        richtigezahlen++;
                    }
                    // - Noch nicht Vollständig)
                    var geänderterichtigezahlen = richtigezahlen - richtigezahlundOrt;
                    if (geänderterichtigezahlen == -1)
                    {
                        geänderterichtigezahlen = 0;
                    }
                    if (geänderterichtigezahlen == -2)
                    {
                        geänderterichtigezahlen = 0;
                    }
                    if (geänderterichtigezahlen == -3)
                    {
                        geänderterichtigezahlen = 0;
                    }
                    if (geänderterichtigezahlen == -4)
                    {
                        geänderterichtigezahlen = 0;
                    }
                    Console.WriteLine($"Richtige Zahlen: {richtigezahlen}");
                    Console.WriteLine($"Richtige Zahlen mit richtiger Position: {richtigezahlundOrt}");

                    if (richtigezahlundOrt == 4)
                    {
                        return;
                    }
                }
            }
            Console.WriteLine($"Versuche: {versuche}/{maxversuche - 1}");

            Console.WriteLine("Keine Versuche übrig");
            Console.WriteLine("YOU LOOSE");
            Console.WriteLine($"Richtiger Code: {richtigercode}");

            */

            // - Regel versuch_1
            //- ?????????????
        }

        private void GewinnerNachrichtZeigen()
        {
            for (int i = 0; i < 3; i++)
            {
                SchreibNachricht("YOU WIN");
            }
        }

        private Code LeseAntwortCode()
        {
            while (true)
            {
                SchreibNachricht("Gebe deinen Code ein(1 Zahl nach der anderen(Von 1-4))", false);

                var Zahl1 = Console.ReadKey();
                var Zahl2 = Console.ReadKey();
                var Zahl3 = Console.ReadKey();
                var Zahl4 = Console.ReadKey();
                Console.WriteLine();

                var code = new Code
                {
                    Zahl1 = Zahl1.KeyChar.ToString(),
                    Zahl2 = Zahl2.KeyChar.ToString(),
                    Zahl3 = Zahl3.KeyChar.ToString(),
                    Zahl4 = Zahl4.KeyChar.ToString(),
                };

                if(_zahlen.Contains(code.Zahl1)
                    && _zahlen.Contains(code.Zahl2) 
                    && _zahlen.Contains(code.Zahl3)
                    && _zahlen.Contains(code.Zahl4))
                {
                    return code;
                }

                Console.WriteLine("=> Code ungültig, bitte nochmals.");
            }
        }

        private Code MachNeuenGeheimCode()
        {
            // - Random Code mit zahlen aus Liste erstellen
            var random = new Random();

            var code = new Code()
            {
                Zahl1 = _zahlen[random.Next(0, 4)],
                Zahl2 = _zahlen[random.Next(0, 4)],
                Zahl3 = _zahlen[random.Next(0, 4)],
                Zahl4 = _zahlen[random.Next(0, 4)],
            };

            return code;
            // var richtigercode = $"{geheimZahl1}{geheimZahl2}{geheimZahl3}{geheimZahl4}";
        }

        private void SchreibNachricht(string nachricht, bool zeichneLinien = true)
        {
            if (zeichneLinien)
            {
                ZeichneLinie();
            }

            Console.WriteLine($">> {nachricht}");

            if (zeichneLinien)
            {
                ZeichneLinie();
            }
        }

        public void ZeichneLinie()
        {
            Console.WriteLine(new string('-', 80));
        }
    }
}
