using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versuch_1_Mastermind
{
    public class Code
    {
        public string Zahl1 { get; set; }
        public string Zahl2 { get; set; }
        public string Zahl3 { get; set; }
        public string Zahl4 { get; set; }

        public static Code FromString(string s)
        {
            return new Code
            {
                Zahl1 = s[0].ToString(),
                Zahl2 = s[1].ToString(),
                Zahl3 = s[2].ToString(),
                Zahl4 = s[3].ToString(),
            };
        }

        public List<string> MachListe()
        {
            return new List<string>()
            {
                Zahl1, Zahl2, Zahl3, Zahl4
            };
        }

        public override string ToString()
        {
            return $"{Zahl1}{Zahl2}{Zahl3}{Zahl4}";
        }

        public bool IsCodeGleichWie(Code andererCode)
        {
            var zahl1IstGleich = Zahl1 == andererCode.Zahl1;
            var zahl2IstGleich = Zahl2 == andererCode.Zahl2;
            var zahl3IstGleich = Zahl3 == andererCode.Zahl3;
            var zahl4IstGleich = Zahl4 == andererCode.Zahl4;

            var sindAlleGleich = zahl1IstGleich && zahl2IstGleich && zahl3IstGleich && zahl4IstGleich;

            return sindAlleGleich;
        }

        public int BerechneRichtigeZahlUndRichtigerOrt(Code andererCode)
        {
            var richtigeZahlUndOrt = 0;
            if (Zahl1 == andererCode.Zahl1)
            {
                richtigeZahlUndOrt++;
            }
            if (Zahl2 == andererCode.Zahl2)
            {
                richtigeZahlUndOrt++;
            }
            if (Zahl3 == andererCode.Zahl3)
            {
                richtigeZahlUndOrt++;
            }
            if (Zahl4 == andererCode.Zahl4)
            {
                richtigeZahlUndOrt++;
            }
            return richtigeZahlUndOrt;
        }

        public static int BerechneRichtigeZahlenInAntwort(Code richtigerCode, Code antwortCode)
        {
            var richtigeZahlenInAntwort = 0;

            var geheimZahlen = richtigerCode.MachListe();
            var antwortZahlen = antwortCode.MachListe();

            // listen ohne korrekte einträge
            var geheimZahlenOhneKorrekte = new List<string>();
            var antwortZahlenOhneKorrekte = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                var gZ = geheimZahlen[i];
                var aZ = antwortZahlen[i];

                if (gZ != aZ)
                {
                    geheimZahlenOhneKorrekte.Add(gZ);
                    antwortZahlenOhneKorrekte.Add(aZ);
                }
            }

            foreach (var antwortZahl in antwortZahlenOhneKorrekte)
            {
                if(geheimZahlenOhneKorrekte.Contains(antwortZahl))
                {
                    richtigeZahlenInAntwort++;

                    var index = geheimZahlenOhneKorrekte.IndexOf(antwortZahl);
                    if(index != -1)
                    {
                        geheimZahlenOhneKorrekte.RemoveAt(index);
                    }
                }
            }

            return richtigeZahlenInAntwort;
        }
    }
}
