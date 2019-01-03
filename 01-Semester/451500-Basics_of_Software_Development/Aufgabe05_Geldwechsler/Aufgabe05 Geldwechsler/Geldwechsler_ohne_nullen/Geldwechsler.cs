using System;

namespace Geldwechsler_ohne_Nullen
{
    class Geldwechsler
    {
        private int anzahl001, anzahl002, anzahl005, anzahl010, anzahl020, anzahl050;
        private int anzahl100, anzahl200, anzahl500, anzahl1000;
        private int restCent;
        // differenz nun private, da der Wert nur durch den 
        // nachfolgenden Custom-Konstruktor gesetzt werden soll.
        private decimal restEuro;
        // Custom-Konstruktor setzt den zurückzugebenden Betrag
        public Geldwechsler(decimal auszahlBetrag)
        {
            restEuro = auszahlBetrag;
        }

        private void berechneWechselGeld()
        {
            // Die Methode ist private, weil sie ausschließlich durch die unten
            // stehende Methode aufgerufen werden soll. Nur so ist sichergestellt,
            // dass die Berechnung immmer VOR der Ausgabe durchgeführt wird.

            // Berechnungsteil
            // Differenz aus Instanzvariabler differenz in eine Ganzzahl umwandeln
            // Dies muss geschehen, weil die nachfolgenden Divisionen andernfalls immer
            // nicht ganzzahlige Ergebnisse aufwiesen (z.B. 0,75) und eine Auszahlung von
            // bspw. 0,75 Scheinen oder Stücken ja nicht möglich ist.
            // 1. Möglichkeit: explizite Typumwandlung decimal in int
            restCent = (int)(restEuro * 100);
            // 2. Möglichkeit: Methode ToInt32 der Klasse Convert
            restCent = Convert.ToInt32(restEuro * 100);

            // Jetzt die Anzahl für alle Scheine und Münzen berechnen
            // Anzahl Zehn-Euro-Scheine und verbleibenden Rest berechnen
            anzahl1000 = restCent / 1000;
            restCent = restCent % 1000;
            // Anzahl Fünf-Euro-Scheine und verbleibenden Rest berechnen
            anzahl500 = restCent / 500;
            restCent = restCent % 500;
            // Anzahl Zwei-Euro-Stücke und verbleibenden Rest berechnen
            anzahl200 = restCent / 200;
            restCent = restCent % 200;
            // Anzahl Ein-Euro-Stücke und verbleibenden Rest berechnen
            anzahl100 = restCent / 100;
            restCent = restCent % 100;
            // Anzahl 50-Cent-Stücke und verbleibenden Rest berechnen
            anzahl050 = restCent / 50;
            restCent = restCent % 50;
            // Anzahl 20-Cent-Stücke und verbleibenden Rest berechnen
            anzahl020 = restCent / 20;
            restCent = restCent % 20;
            // Anzahl 10-Cent-Stücke und verbleibenden Rest berechnen
            anzahl010 = restCent / 10;
            restCent = restCent % 10;
            // Anzahl 5-Cent-Stücke und verbleibenden Rest berechnen
            anzahl005 = restCent / 5;
            restCent = restCent % 5;
            // Anzahl 2-Cent-Stücke und verbleibenden Rest berechnen
            anzahl002 = restCent / 2;
            restCent = restCent % 2;
            // Rest ist entweder 0 oder kann nur noch ein 1-Cent-Stück sein
            anzahl001 = restCent;
        }

         
        public void zeigeWechselGeld()
        {
            // Zunächst Wechselgeld berechnen
            berechneWechselGeld();
            // Ausgabeteil: Ausgaben erfolgen nur, wenn die Anzahl der zurückzugebenden
            // Einheit von 0 verschieden ist
            Console.WriteLine("\nSie erhalten {0:f2} Euro zurück", restEuro);
            if (anzahl1000 != 0)
                Console.WriteLine("10-Euro-Scheine  : {0,2}", anzahl1000);
            if (anzahl500 != 0)
                Console.WriteLine("5-Euro-Scheine   : {0,2}", anzahl500);
            if (anzahl200 != 0)
                Console.WriteLine("2-Euro-Stücke    : {0,2}", anzahl200);
            if (anzahl100 != 0)
                Console.WriteLine("1-Euro-Stücke    : {0,2}", anzahl100);
            if (anzahl050 != 0)
                Console.WriteLine("50-Cent-Stücke   : {0,2}", anzahl050);
            if (anzahl020 != 0)
                Console.WriteLine("20-Cent-Stücke   : {0,2}", anzahl020);
            if (anzahl010 != 0)
                Console.WriteLine("10-Cent-Stücke   : {0,2}", anzahl010);
            if (anzahl005 != 0)
                Console.WriteLine("5-Cent-Stücke    : {0,2}", anzahl005);
            if (anzahl002 != 0)
                Console.WriteLine("2-Cent-Stücke    : {0,2}", anzahl002);
            if (anzahl001 != 0)
                Console.WriteLine("1-Cent-Stück     : {0,2}", anzahl001);
        }
    }
}
