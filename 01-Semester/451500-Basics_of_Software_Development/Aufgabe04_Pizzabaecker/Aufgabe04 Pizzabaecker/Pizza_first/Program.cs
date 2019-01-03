using System;
using GSE;

/* 
 * Programm         pizza_first.cproj
 * Projekt          pizze.sln
 * Veranstaltung    GSE
 * Art              Übungsaufgabe
 * Kontext          Sprachelemente
 * Autor            Prof. Thomas Müller
 * Hinweis          Einfachste Version des Pizzabäckers
*/

namespace Pizza_first
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konstantendeklaraton
            const double FIXKOSTEN = 2,
                         VARKOSTENQCM = 0.01,
                         GEWINNAUFSCHLAG = 50,
                         GEWINNFAKTOR = 1 + GEWINNAUFSCHLAG / 100;

            // Variablendeklaration
            byte durchmesser;
            double flaeche,
                   variableKosten, gesamtKosten,
                   preis;

            // Programmidentifikation
            Helpers.zeigeTitel("Pizzabäcker (einfache Version)", "Preiskalkulation einer Pizza");
 
            // Eingabeteil für Durchmesser
            Console.Write("Durchmesser der Pizza in cm (max. 255): ");
            durchmesser = Convert.ToByte(Console.ReadLine());

            // Berechnungsteil
            flaeche = Math.Pow(durchmesser, 2) * Math.PI / 4;
            variableKosten = flaeche * VARKOSTENQCM;
            gesamtKosten = variableKosten + FIXKOSTEN;
            // Preis für eine Pizza berechnen 
            preis = gesamtKosten * GEWINNFAKTOR;

            // Ausgabeteil
            Console.WriteLine("\nDie Pizza mit " + durchmesser + " cm Durchmesser kostet " +
                     Math.Round(preis, 2) + " Euro.");

            // Programmendemeldung
            Helpers.zeigeProgrammende();
        }
    }
}
