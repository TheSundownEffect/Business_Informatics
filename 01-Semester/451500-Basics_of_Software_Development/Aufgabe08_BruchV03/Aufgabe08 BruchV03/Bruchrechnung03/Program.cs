
using System;
using Bruchrechnung;
using GSE;

namespace Bruchrechnung03
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.zeigeTitel("Bruchrechnung", "Version 3");

            #region Konstante und Variable des Beispiels deklarieren
            // Konstante des Beispiels für zwei Brüche deklarieren
            // Wenn andere Zahlen getestet werden sollen, bitte hier ändern:
            const int ZAEHLER = 35, NENNER = 100;
            // Bruchinstanz für Beispiel erzeugen
            Bruch b1 = new Bruch();
            #endregion

            #region Eigenschaften testen
            Console.WriteLine("Test der Eigenschaft - Testen Sie auch Nenner mit 0");
            Console.Write("Bitte den Zähler eingeben: ");
            b1.Numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte den Nenner eingeben: ");
            b1.Denominator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Der Bruch b1 lautet nun  : ");
            b1.print();
            Console.WriteLine("Test der Nur-Lese-Eigenschaft Number");
            Console.WriteLine("b1.Numer = " + b1.Number);
            #endregion

            #region Kürzen testen
            Console.WriteLine("\nTest des Kürzens");
            // Zuletzt eingegebenen Bruch als gekürzten Bruch ausgeben
            Console.Write("b1 als gekürzter Bruch: ");
            Bruch.reduce(b1).print();
            
            // Eigenschaften der Bruchinstanz b1 unter Verwendung obiger Konstanten belegen
            Console.WriteLine("\nEigenschaften des Bruchs b1 auf {0} / {1} gesetzt", ZAEHLER, NENNER);
            b1.Numerator = ZAEHLER;
            b1.Denominator = NENNER;
            
            // Test der Klassenmethode
            Console.WriteLine("\nKürzen mit Klassenmethode");
            Console.Write("Bruch b1              = "); b1.print();
            Console.Write("Bruch.reduce(b1)      = "); Bruch.reduce(b1).print();
            Console.Write("Bruch b1              = "); b1.print();
            //Jetzt mal den Bruch kürzen und gekürzten Bruch der Referenz zuweisen
            b1 = Bruch.reduce(b1);
            Console.Write("b1 = Bruch.reduce(b1) = "); b1.print();

            // Eigenschaften der Bruchinstanz b1 unter Verwendung obiger Konstanten belegen
            Console.WriteLine("\nEigenschaften des Bruchs b1 auf {0} / {1} gesetzt", ZAEHLER, NENNER);
            b1.Numerator = ZAEHLER;
            b1.Denominator = NENNER;

            // Test der Instanzmethode
            Console.WriteLine("\nKürzen mit Instanzmethode");
            Console.Write("Bruch b1              = "); b1.print();
            b1.reduce();
            Console.WriteLine("b1.reduce() ausgeführt");
            Console.Write("Bruch b1              = "); b1.print();
            #endregion

            Helpers.zeigeProgrammende();
        }
    }
}
