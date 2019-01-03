using System;

/* Projekt Bruchrechnen
 * Veranstaltung Grundlagen der Softwareentwicklung (451500)
 * Prof. Thomas Müller, FHFL
 * 
 * Version 01 (Aufgabe 06)
 * - Einfache Klasse für Brüche
 * - Private Instanzvariable, die durch Konstruktoren unter deren 
 *   Kontrolle für den Wert des Nenners gesetzt werden
 * - Konstruktoren (4 Überladungen)
 * - Methode print() zur Ausgabe dieses Bruchs auf der Console 
 *   in der Form "numerator / denominator"
 * - Methode dprint() zur Ausgabe des reellen Wertes dieses Bruchs
 * 
 * Weitere Versionen folgen
 * */

namespace Bruchrechnung
{
    class Bruch
    {
        #region Datenbestandteile zur Beschreibung eines Bruchs
        // Instanzvariable zähler und nenner für einen Bruch
        // Beide sind private, da sie nur durch den Konstruktor
        // und unter seiner Kontrolle gesetzt werden dürfen.
        private int numerator;
        private int denominator;
        #endregion

        #region Überladene Konstruktoren
        // Customkonstruktor
        // erzeugt einen neuen Bruch aus übergebenem numerator und 
        // denominator und prüft dabei, ob denominator != 0 ist!
        // Ist denominator == 0, wird ein Bruch mit dem Wert 0 
        // (entspricht 0 / 1) erzeugt.
        public Bruch(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator == 0)
            {
                this.numerator = 0;
                this.denominator = 1;
            }
            else this.denominator = denominator;
        }

        // Überladener Customkonstruktor
        // Erzeugt Bruch aus übergebener Ganzzahl als numerator 
        // und 1 als denominator (36 = 36 / 1)
        // Hier mit obigem Customkonstruktor verkettet
        public Bruch(int zahl) //: this(zahl, 1)
        {
            // Ohne Verkettung müssten hier die Werte gesetzt werden:
            numerator = zahl;
            denominator = 1;
        }

        // Defaultkonstruktor: Erzeugt neuen Bruch als 0 / 1.
        // Damit ist ein Bruch wie jeder einfache numerische
        // Datentyp mit dem Defaultwert 0 initialisiert.
        // Hier mit obigem Customkonstruktor verkettet, womit
        // Bruch(0) aufgerufen wird, der seinerseits Bruch(0,1)
        // aufruft.
        public Bruch() : this(0)
        {
            // Ohne Verkettung müssten hier die Werte gesetzt werden:
            // this.numerator = 0;
            // this.denominator = 1;
        }

        // Copykonstruktor: erzeugt neue Instanz auf Basis einer 
        // übergebenen Bruchinstanz
        // Hier mit obigem Customkonstruktor verkettet
        public Bruch(Bruch aBruch) : this(aBruch.numerator, aBruch.denominator)
        {
            // Ohne Verkettung müssten hier die Werte gesetzt werden:
            // this.numerator = aBruch.numerator;
            // this.denominator = aBruch.denominator;
        }
        
        // Zur Beachtung: In diesem Fall ist es sehr hilfreich, dass 
        // der Standardkonstruktor durch die eigenen Konstruktoren 
        // nicht mehr zur Verfügung steht. Er würde ja als Standard-
        // werte für die Instanzvariablen numerator und denominator 
        // jeweils den Wert 0 verwenden, was im Falle des denominators 
        // ja fatal wäre (Division durch 0)!     
        #endregion

        #region Methoden zur Ausgabe von Brüchen
        // Gibt diesen Bruch in Form "Zähler / Nenner" auf der Konsole
        // aus.
        public void print()
        {
            Console.WriteLine(numerator + " / " + denominator);
        }

        // Gibt den reellen Wert dieses Bruchs auf der Console aus.
        // Achtung: Zähler und Nenner sind ganzzahling, daher muss
        // zur Berechnung des reellen Werts ein Typcasting in jeweils
        // einen double-Wert vorgenommen werden, da anderfalls eine
        // Ganzzahldivision durchgeführt würde.
        public void dprint()
        {
            Console.WriteLine((double)numerator / (double)denominator);
            // Alternativ: Console.WriteLine(Convert.ToDouble(numerator) / Convert.ToDouble(denominator));
        }
        #endregion
    }
}
