using System;
using GSE;  // Klasse Helpers aus dem Namespace GSE einbinden

/* 
 * Programm         Geldwechsler_konstruktor.sln
 * Version          Klasse Geldwechsler durch Konstruktor ergänzt
 * Veranstaltung    GSE
 * Art              Übungsaufgabe
 * Kontext          Sprachelemente
 * Autor            Prof. Thomas Müller
*/

namespace Geldwechsler_konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal essensPreis, bezahlt;

            Helpers.zeigeTitel("Geldwechselautomat der Mensa", "Version mit Konstruktor");
            
            // Eingabeteil
            Console.Write("Essenspreis     : ");
            essensPreis = Decimal.Parse(Console.ReadLine());
            Console.Write("Bezahlter Betrag: ");
            bezahlt = Decimal.Parse(Console.ReadLine());

            Geldwechsler gw = new Geldwechsler(bezahlt - essensPreis);
            gw.zeigeWechselGeld();

            Helpers.zeigeProgrammende();
        }
    }
}
