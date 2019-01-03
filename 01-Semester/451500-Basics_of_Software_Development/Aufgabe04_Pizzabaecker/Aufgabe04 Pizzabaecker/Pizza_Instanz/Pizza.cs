using System;

namespace Pizza_Instanz
{
    class Pizza
    {
        // Konstantendeklarationen
        private const double VARIABLEKOSTEN = 0.01;
        private const double FIXKOSTEN = 2;
        private const double GEWINNAUFSCHLAG = 50;
        private const double GEWINNFAKTOR = 1 + GEWINNAUFSCHLAG / 100;
 
        // Öffentliche Instanzvariable für den Durchmesser
        // Eigentlich sollte man keine öffentlichen Instanz-
        // variablen verwenden, aber wir müssen ja schließlich
        // den Durchmesser unserer Instanz von außerhalb der 
        // Klasse (also aus der Klasse Program) setzen können.
        // Später wird das verbessert durch Konstruktoren
        // oder auch Eigenschaften mit Getter-/Settermethoden
        public byte durchmesser;

        // Öffentliche Instanzmethode zur Preisberechnung
        // Verwendet die Instanzvariable durchmesser der 
		// Pizzainstanz, für die der Preis berechnet werden
        // soll, daher kein Parameter mehr nötig! 
        // Liefert via return den berechneten Preis an den
        // Aufrufer zurück.
        public double berechnePreis()
        {
           // Berechnung mit Zwischenergebnissen
            double flaeche = Math.Pow(durchmesser, 2) * Math.PI / 4;
            double variableKosten = flaeche * VARIABLEKOSTEN;
            double gesamtKosten = variableKosten + FIXKOSTEN;
            double preis = gesamtKosten * GEWINNFAKTOR;
            return preis;
        }
    }
}
