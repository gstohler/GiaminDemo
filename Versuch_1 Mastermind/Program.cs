using System;
using System.Collections.Generic;
using System.Linq;

namespace Versuch_1_Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            var spiel = new Spiel();
            spiel.Play();

            Console.WriteLine("Spiel beendet, ich hoffe du hattest viel Spass!");

            //var leute = new List<Person>();

            //var giamin = new Person();
            //giamin.Vorname = "Giamin";
            //giamin.SchuhGrösse = 36;
            //giamin.Geschwindigkeit = 100;

            //var nicolas = new Person();
            //nicolas.Vorname = "Nicolas";
            //nicolas.SchuhGrösse = 45;
            //nicolas.Geschwindigkeit = 55;

            //var test = nicolas.HatGrössererFüsseAls(giamin);

            //var wurstelHeld = new Superheld();
            //wurstelHeld.Vorname = "Hans";
            //wurstelHeld.SchuhGrösse = 50;
            //wurstelHeld.SuperheldName = "WurstelBurstel";
            //wurstelHeld.Geschwindigkeit = 99;

            //leute.Add(giamin);
            //leute.Add(nicolas);
            //leute.Add(wurstelHeld);

            //for (int i = 0; i < 10; i++)
            //{
            //    foreach (var person in leute)
            //    {
            //        person.Position += person.Geschwindigkeit;
            //    }
            //}

            //foreach (var person in leute)
            //{
            //    Console.WriteLine($"Person: {person}");
            //    Console.WriteLine($"  Vorname: {person.Vorname}");
            //    Console.WriteLine($"  Nachname: {person.SchuhGrösse}");
            //    Console.WriteLine($"  Position: {person.Position}");

            //    var superheld = person as Superheld;
            //    if (superheld != null)
            //    {
            //        Console.WriteLine($"  Vorname: {superheld.Vorname} ist {superheld.SuperheldName}");
            //    }
            //}
            
        }
    }
}