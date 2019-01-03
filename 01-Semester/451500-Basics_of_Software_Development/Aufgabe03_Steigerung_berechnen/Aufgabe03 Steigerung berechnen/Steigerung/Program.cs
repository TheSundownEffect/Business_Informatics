using System;
using GSE;
/* 
 * Programm         steigerung.sln
 * Veranstaltung    GSE
 * Art              Übungsaufgabe 3
 * Kontext          Überladene Klassenmethoden mit Returnwert
 * Autor            Prof. Thomas Müller
*/
namespace Steigerung
{
    class Program
    {
        // Hinweise: https://pagehalffull.wordpress.com/2012/10/30/rounding-doubles-in-c/
        //           http://www.mycsharp.de/wbb2/thread.php?threadid=64462    
        static void Main(string[] args)
        {
            Helpers.zeigeTitel("Helperklasse", "Jährliche Umsatzsteigerung berechnen");

            // Eingaben der Werte für Jahreszahlen und Umsatzwerte
            Console.Write("1. Umsatzjahr          : ");
            int umsatzJahr1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Umsatz im Jahr " + umsatzJahr1 + "    : ");
            double umsatz1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Umsatzjahr          : ");
            int umsatzJahr2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Umsatz im Jahr " + umsatzJahr2 + "    : ");
            double umsatz2 = Convert.ToDouble(Console.ReadLine());

            // Berechnung Faktor und Prozentwert des gesamten Anstiegs
            double gesamtFaktor = umsatz2 / umsatz1;
            double gesamtAnstieg = (gesamtFaktor - 1 ) * 100;
            // Berechnung Faktor und Prozentwert des mittleren Anstiegs
            double mittlererFaktor = Helpers.nteWurzel(gesamtFaktor, umsatzJahr2 - umsatzJahr1);
            double mittlererAnstieg = (mittlererFaktor - 1 ) * 100;
            // Berechnung Faktor und Prozentwert des mittleren Anstiegs, gerundet auf 4 Stellen
            double mittlererFaktorGerundet = Helpers.nteWurzel(gesamtFaktor, umsatzJahr2 - umsatzJahr1, 4);
            double mittlererAnstiegGerundet = (mittlererFaktorGerundet - 1) * 100;

            // Ausgabe der ungerundeten Berechnungen
            Console.WriteLine("\nGesamtanstieg " + umsatzJahr1 + "-" + umsatzJahr2 +
                ": " + gesamtAnstieg + " %");
            Console.WriteLine("jhrl. Anstieg " + umsatzJahr1 + "-" + umsatzJahr2 +
                ": " + mittlererAnstieg + " %");
            // Ausgabe des gerundeten Ergebnisse
            Console.WriteLine("jhrl. Anstieg " + umsatzJahr1 + "-" + umsatzJahr2 +
                ": " + mittlererAnstiegGerundet + " %");
            Helpers.zeigeProgrammende();
        }
    }
}
