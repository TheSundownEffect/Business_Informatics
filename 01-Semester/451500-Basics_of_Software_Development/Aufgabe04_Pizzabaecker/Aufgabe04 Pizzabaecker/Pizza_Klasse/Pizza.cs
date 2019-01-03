using System;

namespace Pizza_Klasse
{
    class Pizza
    {
        // Private Konstante für die Preisberechnung einer Pizza
        // Denkbar wäre es auch, diese Konstanten direkt in der 
        // nachfolgenden Methode zu deklarieren. Durch die Deklaration
        // bei der Klasse könnten auch andere Methoden der Klasse darauf
        // zugreifen.
        private const double VARIABLEKOSTEN = 0.01;
        private const double FIXKOSTEN = 2;
        private const double GEWINNAUFSCHLAG = 50;
        private const double GEWINNFAKTOR = 1 + GEWINNAUFSCHLAG / 100;

        // Öffentliche Klassenmethode zur Preisberechnung
        // Benötigt die Übergabe des Durchmesser, da keine
        // Pizzainstanz mit einem Datenfeld für den
        // Durchmesser existiert. Liefert via return den 
        // berechneten Preis an den Aufrufer zurück.
        public static double berechnePreis (byte durchmesser)
        {
            double flaeche = Math.Pow(durchmesser, 2) * Math.PI / 4;
            double variableKosten = flaeche * VARIABLEKOSTEN;
            double gesamtKosten = variableKosten + FIXKOSTEN;
            double preis = gesamtKosten * GEWINNFAKTOR;
            return Math.Round(preis, 2);
        }
    }
}
