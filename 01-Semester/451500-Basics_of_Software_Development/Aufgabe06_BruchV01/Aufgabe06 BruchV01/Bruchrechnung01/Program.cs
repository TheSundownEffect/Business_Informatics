using System;
using GSE;
using Bruchrechnung;

namespace Bruchrechnung01
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.zeigeTitel("Bruchrechnung", "Version 1");

            // Test Defaultkonstruktor
            Console.WriteLine("Test Defaultkonstruktor");
            Bruch b1 = new Bruch();
            Console.WriteLine("Bruch b1 = new Bruch() ausgeführt");
            Console.Write("b1.print()   -> "); b1.print();
            Console.Write("b1.dprint()  -> "); b1.dprint();

            // Test Customkonstruktor
            Console.WriteLine("\nTest Customkonstruktoren");
            Bruch b2 = new Bruch(4, 7);
            Console.WriteLine("Bruch b2 = new Bruch(4, 7) ausgeführt");
            Console.Write("b2.print()   -> "); b2.print();
            Console.Write("b2.dprint()  -> "); b2.dprint();

            // Test Customkonstruktor
            Bruch b3 = new Bruch(4, 0);
            Console.WriteLine("Bruch b3 = new Bruch(4, 0) ausgeführt");
            Console.Write("b3.print()   -> "); b3.print();
            Console.Write("b3.dprint()  -> "); b3.dprint();

            // Test Customkonstruktor
            Bruch b4 = new Bruch(4);
            Console.WriteLine("Bruch b4 = new Bruch(4) ausgeführt");
            Console.Write("b4.print()   -> "); b4.print();
            Console.Write("b4.dprint()  -> "); b4.dprint();

            // Test Customkonstruktor mit Eingaben
            Console.Write("Zähler eingeben: ");
            int zaehler = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nenner eingeben: ");
            int nenner = Convert.ToInt32(Console.ReadLine());
            Bruch b5 = new Bruch(zaehler, nenner);
            Console.WriteLine("Bruch b5 = new Bruch({0}, {1}) ausgeführt", zaehler, nenner);
            Console.Write("b5.print()   -> "); b5.print();
            Console.Write("b5.dprint()  -> "); b5.dprint();

            // Test Copykonstruktor
            Console.WriteLine("\nTest Copykonstruktor");            
            Bruch b6 = new Bruch(b5);
            Console.WriteLine("Bruch b6 = new Bruch(b5) ausgeführt");
            Console.Write("b6.print()   -> "); b6.print();
            Console.Write("b6.dprint()  -> "); b6.dprint();
            

            // Test Zuweisung
            Console.WriteLine("\nTest Zuweisung von Referenzvariablen");
            b1 = b6;
            Console.WriteLine("b1 = b6 ausgeführt");
            Console.Write("b1.print()   -> "); b1.print();
            Console.Write("b1.dprint()  -> "); b1.dprint();

            Helpers.zeigeProgrammende();
        }
    }
}
