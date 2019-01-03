using GSE;
using System;

namespace Steigerung_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.zeigeTitel("Jährliche Umsatzsteigerung berechnen",
                "Version Variable");

            // Variable deklarieren und Werte festlegen
            int umsatzJahr1 = 2010;
            double umsatz1 = 1234567;
            int umsatzJahr2 = 2016;
            double umsatz2 = 2345678;

            // Ausgabe der Daten 
            Console.WriteLine("Umsatz im Jahr " + umsatzJahr1 + 
                "    : " + umsatz1);
            Console.WriteLine("Umsatz im Jahr " + umsatzJahr2 + 
                "    : " + umsatz2);

            // Berechnung und Speicherung der Werte in Variablen
            double gesamtAnstieg = umsatz2 / umsatz1 * 100 - 100;
            int jahre = umsatzJahr2 - umsatzJahr1;
            double mittlererAnstieg = (Math.Pow(umsatz2 / umsatz1,
                (1d / jahre)) - 1) * 100;

            // Ausgabe der berechneten Variablenwerte
            Console.WriteLine("Gesamtanstieg " + umsatzJahr1 + "-" + umsatzJahr2 +
                ": " + gesamtAnstieg + " %");
            Console.WriteLine("jhrl. Anstieg " + umsatzJahr1 + "-" + umsatzJahr2 + ": " +
                mittlererAnstieg + " %");

            Helpers.zeigeProgrammende();
        }
    }
}
