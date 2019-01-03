using GSE;
using System;

namespace Steigerung_KONSTANTE
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.zeigeTitel("Jährliche Umsatzsteigerung berechnen", 
                "Version KONSTANTE");

            // Variable deklarieren und Werte festlegen
            const int UMSATZJAHR1 = 2010;
            const double UMSATZ1 = 1234567;
            int UMSATZJAHR2 = 2016;
            double UMSATZ2 = 2345678;

            // Ausgabe der Daten 
            Console.WriteLine("Umsatz im Jahr " + UMSATZJAHR1 +
                "    : " + UMSATZ1);
            Console.WriteLine("Umsatz im Jahr " + UMSATZJAHR2 +
                "    : " + UMSATZ2);

            // Berechnung und Speicherung der Werte in Variablen
            double gesamtAnstieg = UMSATZ2 / UMSATZ1 * 100 - 100;
            int jahre = UMSATZJAHR2 - UMSATZJAHR1;
            double mittlererAnstieg = (Math.Pow(UMSATZ2 / UMSATZ1,
                (1d / jahre)) - 1) * 100;

            // Ausgabe der berechneten Variablenwerte
            Console.WriteLine("Gesamtanstieg " + UMSATZJAHR1 + "-" + UMSATZJAHR2 +
                ": " + gesamtAnstieg + " %");
            Console.WriteLine("jhrl. Anstieg " + UMSATZJAHR1 + "-" + UMSATZJAHR2 + ": " +
                mittlererAnstieg + " %");

            Helpers.zeigeProgrammende();
        }
    }
}
