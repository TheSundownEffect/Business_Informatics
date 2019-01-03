using System;
using GSE;  // Namespace mit der Klasse Helpers
namespace Steigerung_Eingabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.zeigeTitel("Jährliche Umsatzsteigerung berechnen",
                "Version Eingabe");

            // Eingaben der Werte für Jahreszahlen und Umsatzwerte
            Console.Write("1. Umsatzjahr          : ");
            int umsatzJahr1 = Convert.ToInt32(Console.ReadLine());
            // wird wie folgt ausgeführt:
            // 1. Console.ReadLine(), z.B. Eingabe von 2000, liefert Zeichenkette "2000" zurück
            // 2. Diese wird Aktualparameter der Klassenmethode ToInt32 der Klasse Convert:
            //    D.h., Convert.ToInt32("2000")
            // 3. Die Methode ToInt32 der Klasse Convert liefert den Integerwert 2000 zurück, der
            // 4. der Variablen umsatzJahr1 zugewiesen wird.
            // Gleiches gilt für die übrigen Werte
            
            Console.Write("Umsatz im Jahr " + umsatzJahr1 + "    : ");
            double umsatz1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Umsatzjahr          : ");
            int umsatzJahr2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Umsatz im Jahr " + umsatzJahr2 + "    : ");
            double umsatz2 = Convert.ToDouble(Console.ReadLine());

            double gesamtAnstieg = umsatz2 / umsatz1 * 100 - 100;
            Console.WriteLine("Gesamtanstieg " + umsatzJahr1 + "-" + umsatzJahr2 + 
                ": " + gesamtAnstieg + " %");

            int jahre = umsatzJahr2 - umsatzJahr1;
            double mittlererAnstieg = Math.Pow(umsatz2 / umsatz1, 
                (1d / jahre) - 1) * 100;
            Console.WriteLine("jhrl. Anstieg " + umsatzJahr1 + "-" + umsatzJahr2 + ": " + 
                mittlererAnstieg + " %");

            Helpers.zeigeProgrammende();
        }
    }
}
