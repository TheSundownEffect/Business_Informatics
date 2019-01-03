using System;
using GSE;  // Klasse Helpers aus dem Namespace GSE einbinden

/* 
 * Programm         Geldwechsler.sln
 * Version          Einfache Implementierung in der Klasse Program
 * Veranstaltung    GSE
 * Art              Übungsaufgabe
 * Kontext          Sprachelemente
 * Autor            Prof. Thomas Müller
*/

namespace Geldwechsler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable für Eingaben und deren Differenz in Euro
            decimal essensPreis, bezahlt, restEuro;
            // Variable für Differenz (Rückzahlbetrag) in Cent
            int restCent;

            // Programmidentifikation
            Helpers.zeigeTitel("Geldwechselautomat der Mensa", "Einfache Version ohne eigene Klasse");

            // Eingabeteil
            Console.Write("Essenspreis     : ");
            essensPreis = Decimal.Parse(Console.ReadLine());
            Console.Write("Bezahlter Betrag: ");
            bezahlt = Decimal.Parse(Console.ReadLine());

            // Berechnungsteil
            // Differenz (= zurückzugebender Betrag) berechnen
            restEuro = bezahlt - essensPreis;
            // Differenz in eine Ganzzahl umwandeln
            // Dies muss geschehen, weil die nachfolgenden Divisionen andernfalls immer
            // nicht ganzzahlige Ergebnisse aufwiesen (z.B. 0,75) und eine Auszahlung von
            // bspw. 0,75 Scheinen oder Stücken ja nicht möglich ist.
            // 1. Möglichkeit: explizite Typumwandlung decimal in int
            restCent = (int)(restEuro * 100);
            // 2. Möglichkeit: Methode ToInt32 der Klasse Convert
            restCent = Convert.ToInt32(restEuro * 100);

            // Jetzt die Anzahl für alle Scheine und Münzen berechnen
            // Anzahl Zehn-Euro-Scheine und verbleibenden Rest berechnen
            int anzahl1000 = restCent / 1000;
            restCent = restCent % 1000;
            // Anzahl Fünf-Euro-Scheine und verbleibenden Rest berechnen
            int anzahl500 = restCent / 500;
            restCent = restCent % 500;
            // Anzahl Zwei-Euro-Stücke und verbleibenden Rest berechnen
            int anzahl200 = restCent / 200;
            restCent = restCent % 200;
            // Anzahl Ein-Euro-Stücke und verbleibenden Rest berechnen
            int anzahl100 = restCent / 100;
            restCent = restCent % 100;
            // Anzahl 50-Cent-Stücke und verbleibenden Rest berechnen
            int anzahl050 = restCent / 50;
            restCent = restCent % 50;
            // Anzahl 20-Cent-Stücke und verbleibenden Rest berechnen
            int anzahl020 = restCent / 20;
            restCent = restCent % 20;
            // Anzahl 10-Cent-Stücke und verbleibenden Rest berechnen
            int anzahl010 = restCent / 10;
            restCent = restCent % 10;
            // Anzahl 5-Cent-Stücke und verbleibenden Rest berechnen
            int anzahl005 = restCent / 5;
            restCent = restCent % 5;
            // Anzahl 2-Cent-Stücke und verbleibenden Rest berechnen
            int anzahl002 = restCent / 2;
            restCent = restCent % 2;
            // Rest ist entweder 0 oder kann nur noch ein 1-Cent-Stück sein
            int anzahl001 = restCent;


            // Ausgabeteil
            Console.WriteLine("\nSie erhalten {0:f2} Euro zurück", restEuro);
            Console.WriteLine("10-Euro-Scheine  : {0,2}", anzahl1000);
            Console.WriteLine("5-Euro-Scheine   : {0,2}", anzahl500);
            Console.WriteLine("2-Euro-Stücke    : {0,2}", anzahl200);
            Console.WriteLine("1-Euro-Stücke    : {0,2}", anzahl100);
            Console.WriteLine("50-Cent-Stücke   : {0,2}", anzahl050);
            Console.WriteLine("20-Cent-Stücke   : {0,2}", anzahl020);
            Console.WriteLine("10-Cent-Stücke   : {0,2}", anzahl010);
            Console.WriteLine("5-Cent-Stücke    : {0,2}", anzahl005);
            Console.WriteLine("2-Cent-Stücke    : {0,2}", anzahl002);
            Console.WriteLine("1-Cent-Stück     : {0,2}", anzahl001);

            // Programmendemeldung
            Helpers.zeigeProgrammende();
        }
}
}
