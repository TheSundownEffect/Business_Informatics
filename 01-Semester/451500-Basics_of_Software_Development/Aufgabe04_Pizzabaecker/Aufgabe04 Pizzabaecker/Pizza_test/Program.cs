// Setzen der Compilerdirektive test durch Wegnehmen der 
// Kommentarzeichen in der folgenden Zeile möglich.

// #define test  // siehe Anmerkungen unten

using System;
using GSE;

/* 
 * Programm         pizza_test.cproj
 * Projekt          pizze.sln
 * Veranstaltung    GSE
 * Art              Übungsaufgabe
 * Kontext          Sprachelemente
 * Autor            Prof. Thomas Müller
 * Hinweis          Compilerdirektiven zum Testen von Werten
*/

namespace Pizza_test
{
    class Program
    {
        static void Main(string[] args)
        {

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
            durchmesser = byte.Parse(Console.ReadLine());

            // Berechnungsteil
            flaeche = Math.Pow(durchmesser, 2) * Math.PI / 4;
            variableKosten = flaeche * VARKOSTENQCM;
            gesamtKosten = variableKosten + FIXKOSTEN;
            // Preis für eine Pizza berechnen 
            preis = gesamtKosten * GEWINNFAKTOR;

            // Ausgabeteil
            Console.WriteLine("\nDie Pizza mit {0} cm Durchmesser kostet {1,0:n} EUR.",
                durchmesser, preis);

#if test
            // Einige Testausgaben
            Console.WriteLine("\nTestausgaben");
            Console.WriteLine("Fixkosten      : {0,10:n} EUR", FIXKOSTEN);
            Console.WriteLine("var. Kosten/qcm: {0,10:n} EUR", VARKOSTENQCM);
            Console.WriteLine("Gewinnaufschlag: {0,10:n} %", GEWINNAUFSCHLAG);
            Console.WriteLine("Fläche         : {0,10:n} qcm", flaeche);
            Console.WriteLine("Variable Kosten: {0,10:n} EUR", variableKosten);
            Console.WriteLine("Gesamtkosten   : {0,10:n} EUR", gesamtKosten);
#endif
            // Programmendemeldung
            Helpers.zeigeProgrammende();
        }
    }
}
/* Hinweise
 * Das Programm demonstriert die Verwendung von Direktiven. Zu Beginn
 * des Quelltextes kann eine Direktive mittel #define <name> gesetzt
 * werden. Mittels der Bedingung #if <name> wird geprüft, ob die Di-
 * rektive <name> gesetzt ist. Ist sie gesetzt, wird der Code zwischen
 * #if <name> und #endif ausgeführt, sonst nicht. Durch Kommentierung
 * der #define <name> - Direktive wird die Direktive <name> nicht gesetzt.
*/