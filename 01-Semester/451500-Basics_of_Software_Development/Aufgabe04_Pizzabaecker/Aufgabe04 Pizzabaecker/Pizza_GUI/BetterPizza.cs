using System;

namespace Pizza_Klasse
{
    // Zur Beachtung: Klasse Pizza enthält keinerlei Ein- oder Ausgaben,
    // wodurch die selbe Klasse später auch in GUI-Anwendungen einsetz-
    // bar ist.

    class Pizza
    {
       
        // Instanzvariable
        private byte durchmesser;

        // this = die aktuelle Instanz, die die Methode aufruft.
        // In Klasse Program also p. This unterscheidet hier die
        // Instanzvariable durchmesser von p vom gleichnamigen 
        // Parameter durchmesser.
        public void setDurchmesser(byte durchmesser)
        {
            this.durchmesser = durchmesser;
        }

        // Später wird das durch einen Custom-Konstruktor erledigt werden:
        // public Pizza(byte durchmesser)
        // {
        //    this.durchmesser = durchmesser;
        // }

        // Private Instanzmethode zur Preisberechnung
        private double berechnePreis ()
        {
            // Konstantendeklarationen
            const double VARIABLEKOSTEN = 0.01;
            const double FIXKOSTEN = 2;
            const double GEWINNAUFSCHLAG = 50;
            const double GEWINNFAKTOR = 1 + GEWINNAUFSCHLAG / 100;
            // Berechnung mit Zwischenergebnissen
            double flaeche = Math.Pow(durchmesser, 2) * Math.PI / 4;
            double variableKosten = flaeche * VARIABLEKOSTEN;
            double gesamtKosten = variableKosten + FIXKOSTEN;
            double preis = gesamtKosten * GEWINNFAKTOR;
            return preis;
        }

        // Öffentliche Instanzmethode, die den Preis zurückliefert, und 
        // sich dabei der privaten Methode berechnePreis() bedient.
        public double getPreis()
        {
            return Math.Round(berechnePreis(), 2);
        }
    }
}
