using System;
using GSE;  // Klasse Helpers aus dem Namespace GSE einbinden

/* 
 * Programm         Geldwechsler_ohne_nullen.sln
 * Version          Zurückzuzahlende Geldeinheiten nur ausgeben, wenn 
 *                  deren Anzahl > 0 ist (Auswahlstruktur)
 * Veranstaltung    GSE
 * Art              Übungsaufgabe
 * Kontext          Sprachelemente
 * Autor            Prof. Thomas Müller
*/

namespace Geldwechsler_ohne_Nullen
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal essensPreis, bezahlt;

            Helpers.zeigeTitel("Geldwechselautomat der Mensa", "Version: Ausgabe nur von zurückzugebenden Scheinen/Stücken");
            
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
