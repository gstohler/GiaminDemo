using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versuch_1_Mastermind
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime GeburtsDatum { get; set; }
        public int SchuhGrösse { get; set; }

        public int Geschwindigkeit { get; set; }
        public int Position { get; set; }

        public override string ToString()
        {
            return $"{Vorname} {Nachname} | {SchuhGrösse}";
        }

        public bool HatGrössererFüsseAls(Person anderePerson)
        {
            MachIrgendetwasSpezielles();
            return SchuhGrösse > anderePerson.SchuhGrösse;
        }

        private void MachIrgendetwasSpezielles()
        {

        }
    }
}
