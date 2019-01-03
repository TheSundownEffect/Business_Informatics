using System;
using GSE;  // Klasse Helpers aus dem Namespace GSE einbinden

/* 
 * Programm         Geldwechsler_instanz.sln
 * Version          Eigene Klasse für den Geldwechsler
 * Veranstaltung    GSE
 * Art              Übungsaufgabe
 * Kontext          Sprachelemente
 * Autor            Prof. Thomas Müller
*/

namespace Geldwechsler_instanz
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal essensPreis, bezahlt;

            Helpers.zeigeTitel("Geldwechselautomat der Mensa", "Version mit eigener Klasse");

            // Eingabeteil
            Console.Write("Essenspreis     : ");
            essensPreis = Decimal.Parse(Console.ReadLine());
            Console.Write("Bezahlter Betrag: ");
            bezahlt = Decimal.Parse(Console.ReadLine());

            // Instanz des Geldwechslers mit Standardkonstruktor erzeugen
            Geldwechsler gw = new Geldwechsler();
            // öffentliche Instanzvariable setzen
            gw.restEuro = bezahlt - essensPreis;
            // Instanzmethode zur Berechnung und Ausgabe des Wechselgeldes aufrufen
            gw.zeigeWechselGeld();

            Helpers.zeigeProgrammende();
        }
    }
}
