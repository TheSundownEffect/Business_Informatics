using System;

/* Projekt Bruchrechnen
 * Veranstaltung Grundlagen der Softwareentwicklung (450500)
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
 * Version 02 (Aufgabe 07)
 * - Instanzmethoden Bruchaddition, -multiplikation, [-subtraktion, -division]
 * - Klassenmethoden Bruchaddition, -multiplikation, [-subtraktion, -division]
 * 
 * Weitere Informationen: http://de.wikipedia.org/wiki/Bruchrechnung
 *  
 * Weitere Versionen folgen
 * */

namespace Bruchrechnung
{
    class Bruch
    {
        #region Version 01 - Aufgabe 06
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
        public Bruch(int zahl) : this(zahl, 1)
        {
            // Ohne Verkettung müssten hier die Werte gesetzt werden,
			// wobei this auch entfallen kann.
            // this.numerator = zahl;
            // this.denominator = 1;
        }

        // Defaultkonstruktor: Erzeugt neuen Bruch als 0 / 1.
        // Damit ist ein Bruch wie jeder einfache numerische
        // Datentyp mit dem Defaultwert 0 initialisiert.
        // Hier mit obigem Customkonstruktor verkettet
        public Bruch() : this(0, 1)
        {
            // Ohne Verkettung müssten hier die Werte gesetzt werden,
			// wobei this auch entfallen kann.
            // this.numerator = 0;
            // this.denominator = 1;
        }

        // Copykonstruktor: erzeugt neue Instanz auf Basis einer 
        // übergebenen Bruchinstanz
        // Hier mit obigem Customkonstruktor verkettet
        public Bruch(Bruch aBruch) : this(aBruch.numerator, aBruch.denominator)
        {
            // Ohne Verkettung müssten hier die Werte gesetzt werden,
			// wobei this auch entfallen kann.
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

        #region Ausgabe von Brüchen
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
        }
        #endregion
        #endregion

        #region Version 02 - Aufgabe 07

        #region Bruchaddition
        #region Addition eines Bruch oder einer Zahl zu diesem Bruch (Instanzmethoden)
        // Addition eines Bruch zu dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird geändert
        // this könnte hier auch entfallen
        public void add(Bruch aBruch)
        {
            // Wir berechnen ZUERST den numerator dieses Bruchs, weil wir den
            // bei der Berechnung des denominators nicht brauchen!
            this.numerator = this.numerator * aBruch.denominator
                           + this.denominator * aBruch.numerator;
            this.denominator = this.denominator * aBruch.denominator;
            // Würden wir diese beiden Anweisungen in der Reihenfolge tauschen,
            // würde ZUERST this.denominator geändert und dieser geänderte Wert
            // in die Berechnung von this.numerator eingehen: ein klassischer
            // Seiteneffekt, der schwer zu lokalisieren ist.
        }

        // Addition einer Zahl zu dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird geändert
        // this könnte hier auch entfallen
        public void add(int aZahl)
        {
            this.numerator += this.denominator * aZahl;
            // oder durch Aufruf obiger Instanzmethode unter 
            // Verwendung von aZahl als Bruch:
            // this.add(new Bruch(aZahl));
        }
        #endregion

        #region Addition zweier Brüche oder einer Zahl zu einem Bruch (Klassenmethoden)
        // Addition zweier Brüche
        // Liefert das Ergebnis als einen neuen Bruch zurück
        public static Bruch add(Bruch aBruchLeft, Bruch aBruchRight)
        {
            return new Bruch(aBruchLeft.numerator * aBruchRight.denominator
                            + aBruchLeft.denominator * aBruchRight.numerator,
                                aBruchLeft.denominator * aBruchRight.denominator);
            // Alternativ: aBruchLeft in neuen Bruch copy kopieren und zu dieser Kopie
            //             den Bruch aBruchRight addieren mittels vorhandener Instanzmethode
            //             den so entstandenen Bruch zurückliefern (aBruchLeft dadurch unverändert!)
            // Bruch copy = new Bruch (aBruchLeft);
            // copy.add(aBruchRight);
            // return copy;
        }

        // Addition eines Bruchs und einer Zahl 
        // Liefert das Ergebnis als neuen Bruch zurück
        public static Bruch add(Bruch aBruch,  int aZahl)
        {
            return new Bruch(aBruch.numerator + aBruch.denominator * aZahl,
                                aBruch.denominator);
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung der aZahl als Bruch:
            // return Bruch.add(aBruch, new Bruch(aZahl));
        }

        // Addition einer Zahl und eines Bruchs 
        // Liefert das Ergebnis als neuen Bruch zurück
        public static Bruch add(int aZahl, Bruch aBruch)
        {
            // Verwendung obiger Klassenmethode, da aBruch + aZahl
            // dasselbe Ergebnis liefert wie aZahl + aBruch:
            return Bruch.add(aBruch, aZahl);
        }
        #endregion
        #endregion

        #region Bruchmultiplikation
        #region Multiplikation dieses mit einem anderen Bruch oder einer Zahl (Instanzmethoden)
        // Multiplikation dieses mit einem anderen Bruch
        // Ändert den Wert dieses Bruchs
        // this könnte hier auch entfallen
        public void multiply(Bruch aBruch)
        {
            this.numerator *= aBruch.numerator;
            this.denominator *= aBruch.denominator;
        }

        // Multiplikation dieses Bruchs mit einer Zahl
        // Ändert den Wert dieses Bruchs
        // this könnte hier auch entfallen
        public void multiply(int aZahl)
        {
            this.numerator *= aZahl;
            // oder durch Aufruf obiger Instanzmethode unter
            // Verwendung von aZahl als Bruch:
            // this.multiply(new Bruch(aZahl));
        }
        #endregion

        #region Multiplikation zweier Brüche oder eines Bruchs und einer Zahl (Klassenmethoden)
        // Multiplikation zweier Brüche und
        // Liefert das Ergebnis als neuen Bruch zurück
        public static Bruch multiply(Bruch aBruchLeft, Bruch aBruchRight)
        {
            return new Bruch(aBruchLeft.numerator * aBruchRight.numerator,
                                aBruchLeft.denominator * aBruchRight.denominator);
            // Alternativ: aBruchLeft in neuen Bruch copy kopieren, diesen mit aBruchRight multiplizieren
            //             und den multiplizierten Bruch als Ergebnis zurückliefern:
            // Bruch copy = new Bruch(aBruchLeft);
            // copy.multiply(aBruchRight);
            // return copy;
        }

        // Multiplikation eines Bruchs und einer Zahl
        // Liefert das Ergebnis als neuen Bruch zurück
        public static Bruch multiply(Bruch aBruch, int aZahl)
        {
            return new Bruch(aBruch.numerator * aZahl,
                                aBruch.denominator);
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung der aZahl als Bruch:
            // return Bruch.multiply(aBruch, new Bruch(aZahl));
        }

        // Multiplikation einer Zahl und eines Bruchs 
        // Liefert das Ergebnis als neuen Bruch zurück
        public static Bruch multiply(int aZahl, Bruch aBruch)
        {
            // Verwendung obiger Klassenmethode möglich,
            // da aBruch * aZahl = aZahl * aBruch ist:
            return Bruch.multiply(aBruch, aZahl);
        }
        #endregion
        #endregion

        #region Bruchsubtraktion
        #region Subtraktion eines Bruchs oder einer Zahl von diesem Bruch (Instanzmethoden)
        // Subtraktion eines Bruchs von dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird geändert
        // this könnte hier auch entfallen
        public void subtract(Bruch aBruch)
        {
            this.numerator = this.numerator * aBruch.denominator
                            - this.denominator * aBruch.numerator;
            this.denominator = this.denominator * aBruch.denominator;
        }

        // Subtraktion einer Zahl von dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird geändert
        // this könnte hier auch entfallen
        public void subtract(int aZahl)
        {
            this.numerator -= this.denominator * aZahl;
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung von aZahl als Bruch:
            // this.subtract(new Bruch(aZahl));
        }
        #endregion

        #region Subtraktion zweier Brüche oder einer Zahl von einem Bruch (Klassenmethoden)
        // Subtraktion zweier Brüche 
        // Liefert das Ergebnis als einen neuen Bruch zurück
        public static Bruch subtract(Bruch aBruchLeft, Bruch aBruchRight)
        {
            return new Bruch(aBruchLeft.numerator * aBruchRight.denominator
                            - aBruchLeft.denominator * aBruchRight.numerator,
                                aBruchLeft.denominator * aBruchRight.denominator);
            // Alternativ: aBruchLeft in neuen Bruch copy kopieren, von copy aBruchRight abziehen
            //             und copy als Ergebnis zurückliefern:
            // Bruch copy = new Bruch(aBruchLeft);
            // copy.subtract(aBruchRight);
            // return copy;

        }

        // Subtraktion einer Zahl von einem Bruch 
        // Liefert das Ergebnis als neuen Bruch zurück
        public static Bruch subtract(Bruch aBruch, int aZahl)
        {
            return new Bruch(aBruch.numerator - aBruch.denominator * aZahl,
                                aBruch.denominator);
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung von aZahl als Bruch:
            // return Bruch.subtract(aBruch, new Bruch(aZahl));
        }

        // Subtraktion eines Bruchs von einer Zahl 
        // Liefert das Ergebnis als neuen Bruch zurück
        public static Bruch subtract(int aZahl, Bruch aBruch)
        {
            return new Bruch(aZahl * aBruch.denominator - aBruch.numerator, 
                                aBruch.denominator);
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung von aZahl als Bruch:
            // return Bruch.subtract(new Bruch(aZahl), aBruch);
        }
        #endregion
        #endregion

        #region Bruchdivision
        #region Division dieses durch einen anderen Bruch oder eine Zahl (Instanzmethoden)
        // Division dieses durch einen anderen Bruch
        // Verfahren: Multiplikation mit dem Kehrwert, da andernfalls bei 
        //            Ganzzahlen Problem der Ganzzahldivision auftritt!
        // Ändert den Wert dieses Bruchs
        // this könnte hier auch entfallen
        public void divide(Bruch aBruch)
        {
            this.numerator *= aBruch.denominator;
            this.denominator *= aBruch.numerator;
        }

        // Division dieses Bruchs durch eine Zahl
        // Verfahren: Multiplikation mit dem Kehrwert, da andernfalls bei 
        //            Ganzzahlen Problem der Ganzzahldivision auftritt!
        // Ändert den Wert dieses Bruchs
        // this könnte hier auch entfallen
        public void divide (int aZahl)
        {
            this.denominator *= aZahl;
            // oder durch Aufruf obiger Instanzmethode unter
            // Verwendung von aZahl als Bruch
            // this.divide(new Bruch(aZahl));
        }
        #endregion
        
        #region Division zweier Brüche oder eines Bruchs durch eine Zahl (Klassenmethoden)
        // Divsion zweier Brüche
        // Verfahren: Multiplikation mit dem Kehrwert, da andernfalls bei 
        //            Ganzzahlen Problem der Ganzzahldivision auftritt!
        // Liefert das Ergebnis als neuen Bruch zurück
        public static Bruch divide(Bruch aBruchLeft, Bruch aBruchRight)
        {
            return new Bruch(aBruchLeft.numerator * aBruchRight.denominator,
                                aBruchLeft.denominator * aBruchRight.numerator);
            // Alternativ: aBruchLeft in neuen Bruch copy kopieren, copy durch aBruchRight
            // dividieren und copy als Erebnis zurückliefern:
            // Bruch copy = new Bruch(aBruchLeft);
            // copy.divide(aBruchRight);
            // return copy;

        }

        // Division eines Bruchs durch eine Zahl
        // Verfahren: Multiplikation mit dem Kehrwert, da andernfalls bei 
        //            Ganzzahlen Problem der Ganzzahldivision auftritt!
        // Liefert das Ergebnis als neuen Bruch zurück
        public static Bruch divide(Bruch aBruch, int aZahl)
        {
            return new Bruch(aBruch.numerator,
                                aBruch.denominator * aZahl);
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung von aZahl als Bruch:
            // return Bruch.divide(aBruch, new Bruch(aZahl));
        }

        // Division einer Zahl durch einen Bruch 
        // Liefert das Ergebnis als neuen Bruch zurück
        public static Bruch divide (int aZahl, Bruch aBruch)
        {
            // Aufruf obiger Klassenmethode unter
            // Verwendung von aZahl als Bruch:
            return Bruch.divide(new Bruch(aZahl), aBruch);
        }
        #endregion
        #endregion

        #endregion
    }
}
