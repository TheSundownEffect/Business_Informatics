using System;

/* Projekt Bruchrechnen
 * Veranstaltung Grundlagen der Softwareentwicklung (450500)
 * Prof. Thomas M�ller, FHFL
 * 
 * Version 01 (Aufgabe 06)
 * - Einfache Klasse f�r Br�che
 * - Private Instanzvariable, die durch Konstruktoren unter deren 
 *   Kontrolle f�r den Wert des Nenners gesetzt werden
 * - Konstruktoren (4 �berladungen)
 * - Methode print() zur Ausgabe dieses Bruchs auf der Console 
 *   in der Form "numerator / denominator"
 * - Methode dprint() zur Ausgabe des reellen Wertes dieses Bruchs
 * 
 * Version 02 (Aufgabe 07)
 * - Instanzmethoden Bruchaddition, -multiplikation, [-subtraktion, -division]
 * - Klassenmethoden Bruchaddition, -multiplikation, [-subtraktion, -division]
 * 
 * Version 03 (Aufgabe 08)
 * - Eigenschaften eines Bruchs mit getter-/setter-Methoden
 * - Nur-Lese-Eigenschaft double Number
 * - Instanz- und Klassenmethode zum K�rzen eines Bruchs
 * 
 * Weitere Informationen: http://de.wikipedia.org/wiki/Bruchrechnung
 *  
 * */

namespace Bruchrechnung
{
    class Bruch
    {
        #region Version 01 - Aufgabe 06
        #region Datenbestandteile zur Beschreibung eines Bruchs
        // Instanzvariable z�hler und nenner f�r einen Bruch
        // Beide sind private, da sie nur durch den Konstruktor
        // und unter seiner Kontrolle gesetzt werden d�rfen.
        private int numerator;
        private int denominator;
        // Die erg�nzten Eigenschaften finden Sie ausnahmsweise
        // mal unten in der Region der Aufgabe 08
        #endregion

        #region �berladene Konstruktoren
        // Customkonstruktor
        // erzeugt einen neuen Bruch aus �bergebenem numerator und 
        // denominator und pr�ft dabei, ob denominator != 0 ist!
        // Ist denominator == 0, wird ein Bruch mit dem Wert 0 
        // (entspricht 0 / 1) erzeugt.
        //public Bruch(int numerator, int denominator)
        //{
        //    this.numerator = numerator;
        //    if (denominator == 0)
        //    {
        //        this.numerator = 0;
        //        this.denominator = 1;
        //    }
        //    else this.denominator = denominator;
        //}
        // ACHTUNG: Neue Implementierung des Customkonstruktors im Kontext
        //          der Aufgabe 08 unter Nutzung der Eigenschaft Denominator! 
        //          Siehe unten in der Region Version03 - Aufgabe08


        // �berladener Customkonstruktor
        // Erzeugt Bruch aus �bergebener Ganzzahl als numerator 
        // und 1 als denominator (36 = 36 / 1)
        // Hier mit obigem Customkonstruktor verkettet
        public Bruch(int zahl) : this(zahl, 1)
        {
            // Ohne Verkettung m�ssten hier die Werte gesetzt werden:
            // this.numerator = zahl;
            // this.denominator = 1;
        }

        // Defaultkonstruktor: Erzeugt neuen Bruch als 0 / 1.
        // Damit ist ein Bruch wie jeder einfache numerische
        // Datentyp mit dem Defaultwert 0 initialisiert.
        // Hier mit obigem Customkonstruktor verkettet
        public Bruch() : this(0, 1)
        {
            // Ohne Verkettung m�ssten hier die Werte gesetzt werden:
            // this.numerator = 0;
            // this.denominator = 1;
        }

        // Copykonstruktor: erzeugt neue Instanz auf Basis einer 
        // �bergebenen Bruchinstanz
        // Hier mit obigem Customkonstruktor verkettet
        public Bruch(Bruch aBruch) : this(aBruch.numerator, aBruch.denominator)
        {
            // Ohne Verkettung m�ssten hier die Werte gesetzt werden:
            // this.numerator = aBruch.numerator;
            // this.denominator = aBruch.denominator;
        }

        // Zur Beachtung: In diesem Fall ist es sehr hilfreich, dass 
        // der Standardkonstruktor durch die eigenen Konstruktoren 
        // nicht mehr zur Verf�gung steht. Er w�rde ja als Standard-
        // werte f�r die Instanzvariablen numerator und denominator 
        // jeweils den Wert 0 verwenden, was im Falle des denominators 
        // ja fatal w�re (Division durch 0)!     
        #endregion

        #region Ausgabe von Br�chen
        // Gibt diesen Bruch in Form "Z�hler / Nenner" auf der Konsole
        // aus.
        public void print()
        {
            Console.WriteLine(numerator + " / " + denominator);
        }

        // Gibt den reellen Wert dieses Bruchs auf der Console aus.
        // Achtung: Z�hler und Nenner sind ganzzahling, daher muss
        // zur Berechnung des reellen Werts ein Typcasting in jeweils
        // einen double-Wert vorgenommen werden, da anderfalls eine
        // Ganzzahldivision durchgef�hrt w�rde.
        public void dprint()
        {
            Console.WriteLine((double)numerator / (double)denominator);
        }
        #endregion
        #endregion

        #region Version 02 - Aufgabe 07

        #region Addition eines Bruch oder einer Zahl zu diesem Bruch (Instanzmethoden)
        // Addition eines Bruch zu dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird ge�ndert
        public void add(Bruch aBruch)
        {
            this.numerator = this.numerator * aBruch.denominator
                           + this.denominator * aBruch.numerator;
            this.denominator = this.denominator * aBruch.denominator;
        }

        // Addition einer Zahl zu dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird ge�ndert
        public void add(int aZahl)
        {
            this.numerator += this.denominator * aZahl;
            // oder durch Aufruf obiger Instanzmethode unter 
            // Verwendung von aZahl als Bruch:
            // this.add(new Bruch(aZahl));
        }
        #endregion

        #region Addition zweier Br�che oder einer Zahl zu einem Bruch (Klassenmethoden)
        // Addition zweier Br�che
        // Liefert das Ergebnis als einen neuen Bruch zur�ck
        public static Bruch add(Bruch aBruchLeft, Bruch aBruchRight)
        {
            return new Bruch(aBruchLeft.numerator * aBruchRight.denominator
                           + aBruchLeft.denominator * aBruchRight.numerator,
                             aBruchLeft.denominator * aBruchRight.denominator);
            // Alternativ: aBruchLeft kopieren, zur Kopie aBruchRight unter
            //             Verwendung der Instanzmethode addieren
            //             und zur�ckliefern (aBruchLeft dadurch unver�ndert!)
            // Bruch copy = new Bruch (aBruchLeft);
            // copy.add(aBruchRight);
            // return copy;
        }

        // Addition eines Bruchs und einer Zahl 
        // Liefert das Ergebnis als neuen Bruch zur�ck
        public static Bruch add(Bruch aBruch, int aZahl)
        {
            return new Bruch(aBruch.numerator + aBruch.denominator * aZahl,
                             aBruch.denominator);
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung der aZahl als Bruch:
            // return Bruch.add(aBruch, new Bruch(aZahl));
        }

        // Addition einer Zahl und eines Bruchs 
        // Liefert das Ergebnis als neuen Bruch zur�ck
        public static Bruch add(int aZahl, Bruch aBruch)
        {
            // Verwendung obiger Klassenmethode, da aBruch + aZahl
            // dasselbe Ergebnis liefert wie aZahl + aBruch:
            return Bruch.add(aBruch, aZahl);
        }
        #endregion

        #region Multiplikation dieses mit einem anderen Bruch oder einer Zahl (Instanzmethoden)
        // Multiplikation dieses mit einem anderen Bruch
        // �ndert den Wert dieses Bruchs
        public void multiply(Bruch aBruch)
        {
            this.numerator *= aBruch.numerator;
            this.denominator *= aBruch.denominator;
        }

        // Multiplikation dieses Bruchs mit einer Zahl
        // �ndert den Wert dieses Bruchs
        public void multiply(int aZahl)
        {
            this.numerator *= aZahl;
            // oder durch Aufruf obiger Instanzmethode unter
            // Verwendung von aZahl als Bruch:
            // this.multiply(new Bruch(aZahl));
        }
        #endregion

        #region Multiplikation zweier Br�che oder eines Bruchs und einer Zahl (Klassenmethoden)
        // Multiplikation zweier Br�che und
        // Liefert das Ergebnis als neuen Bruch zur�ck
        public static Bruch multiply(Bruch aBruchLeft, Bruch aBruchRight)
        {
            return new Bruch(aBruchLeft.numerator * aBruchRight.numerator,
                             aBruchLeft.denominator * aBruchRight.denominator);
            // Alternativ: aBruchLeft kopieren, diese mit aBruchRight
            // multiplizieren und das Erebnis zur�ckliefern:
            // Bruch copy = new Bruch(aBruchLeft);
            // copy.multiply(aBruchRight);
            // return copy;
        }

        // Multiplikation eines Bruchs und einer Zahl
        // Liefert das Ergebnis als neuen Bruch zur�ck
        public static Bruch multiply(Bruch aBruch, int aZahl)
        {
            return new Bruch(aBruch.numerator * aZahl,
                             aBruch.denominator);
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung der aZahl als Bruch:
            // return Bruch.multiply(aBruch, new Bruch(aZahl));
        }

        // Multiplikation einer Zahl und eines Bruchs 
        // Liefert das Ergebnis als neuen Bruch zur�ck
        public static Bruch multiply(int aZahl, Bruch aBruch)
        {
            // Verwendung obiger Klassenmethode m�glich,
            // da aBruch * aZahl = aZahl * aBruch ist:
            return Bruch.multiply(aBruch, aZahl);
        }
        #endregion

        #region Subtraktion eines Bruchs oder einer Zahl von diesem Bruch (Instanzmethoden)
        // Subtraktion eines Bruchs von dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird ge�ndert
        public void subtract(Bruch aBruch)
        {
            this.numerator = this.numerator * aBruch.denominator
                           - this.denominator * aBruch.numerator;
            this.denominator = this.denominator * aBruch.denominator;
        }

        // Subtraktion einer Zahl von dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird ge�ndert
        public void subtract(int aZahl)
        {
            this.numerator -= this.denominator * aZahl;
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung von aZahl als Bruch:
            // this.subtract(new Bruch(aZahl));
        }
        #endregion

        #region Subtraktion zweier Br�che oder einer Zahl von einem Bruch (Klassenmethoden)
        // Subtraktion zweier Br�che 
        // Liefert das Ergebnis als einen neuen Bruch zur�ck
        public static Bruch subtract(Bruch aBruchLeft, Bruch aBruchRight)
        {
            return new Bruch(aBruchLeft.numerator * aBruchRight.denominator
                           - aBruchLeft.denominator * aBruchRight.numerator,
                             aBruchLeft.denominator * aBruchRight.denominator);
            // Alternativ: aBruchLeft kopieren, von diesee aBruchRight
            // abziehen und das Ergebnis zur�ckliefern:
            // Bruch copy = new Bruch(aBruchLeft);
            // copy.subtract(aBruchRight);
            // return copy;

        }

        // Subtraktion einer Zahl von einem Bruch 
        // Liefert das Ergebnis als neuen Bruch zur�ck
        public static Bruch subtract(Bruch aBruch, int aZahl)
        {
            return new Bruch(aBruch.numerator - aBruch.denominator * aZahl,
                             aBruch.denominator);
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung von aZahl als Bruch:
            // return Bruch.subtract(aBruch, new Bruch(aZahl));
        }

        // Subtraktion eines Bruchs von einer Zahl 
        // Liefert das Ergebnis als neuen Bruch zur�ck
        public static Bruch subtract(int aZahl, Bruch aBruch)
        {
            return new Bruch(aZahl * aBruch.denominator - aBruch.numerator,
                             aBruch.denominator);
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung von aZahl als Bruch:
            // return Bruch.subtract(new Bruch(aZahl), aBruch);
        }
        #endregion

        #region Division dieses durch einen anderen Bruch oder eine Zahl (Instanzmethoden)
        // Division dieses durch einen anderen Bruch
        // Verfahren: Multiplikation mit dem Kehrwert, da andernfalls bei 
        //            Ganzzahlen Problem der Ganzzahldivision auftritt!
        // �ndert den Wert dieses Bruchs
        public void divide(Bruch aBruch)
        {
            this.numerator *= aBruch.denominator;
            this.denominator *= aBruch.numerator;
        }

        // Division dieses Bruchs durch eine Zahl
        // Verfahren: Multiplikation mit dem Kehrwert, da andernfalls bei 
        //            Ganzzahlen Problem der Ganzzahldivision auftritt!
        // �ndert den Wert dieses Bruchs
        public void divide(int aZahl)
        {
            this.denominator *= aZahl;
            // oder durch Aufruf obiger Instanzmethode unter
            // Verwendung von aZahl als Bruch
            // this.divide(new Bruch(aZahl));
        }
        #endregion

        #region Division zweier Br�che oder eines Bruchs durch eine Zahl (Klassenmethoden)
        // Divsion zweier Br�che
        // Verfahren: Multiplikation mit dem Kehrwert, da andernfalls bei 
        //            Ganzzahlen Problem der Ganzzahldivision auftritt!
        // Liefert das Ergebnis als neuen Bruch zur�ck
        public static Bruch divide(Bruch aBruchLeft, Bruch aBruchRight)
        {
            return new Bruch(aBruchLeft.numerator * aBruchRight.denominator,
                             aBruchLeft.denominator * aBruchRight.numerator);
            // Alternativ: aBruchLeft kopieren, durch aBruchRight
            // dividieren und das Erebnis zur�ckliefern:
            // Bruch copy = new Bruch(aBruchLeft);
            // copy.divide(aBruchRight);
            // return copy;

        }

        // Division eines Bruchs durch eine Zahl
        // Verfahren: Multiplikation mit dem Kehrwert, da andernfalls bei 
        //            Ganzzahlen Problem der Ganzzahldivision auftritt!
        // Liefert das Ergebnis als neuen Bruch zur�ck
        public static Bruch divide(Bruch aBruch, int aZahl)
        {
            return new Bruch(aBruch.numerator,
                             aBruch.denominator * aZahl);
            // oder durch Aufruf obiger Klassenmethode unter
            // Verwendung von aZahl als Bruch:
            // return Bruch.divide(aBruch, new Bruch(aZahl));
        }

        // Division einer Zahl durch einen Bruch 
        // Liefert das Ergebnis als neuen Bruch zur�ck
        public static Bruch divide(int aZahl, Bruch aBruch)
        {
            // Aufruf obiger Klassenmethode unter
            // Verwendung von aZahl als Bruch:
            return Bruch.divide(new Bruch(aZahl), aBruch);
        }
        #endregion

        #endregion

        #region Version 03 - Aufgabe 08
        #region Eigenschaften
        // Zur Beachtung: Deklaration der beiden Instanzvariable int numerator 
        // und int denominator oben in Version01 bereits deklariert
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                    denominator = value;
                else
                {
                    numerator = 0;
                    denominator = 1;
                }
            }
        }

        // ACHTUNG: Jetzt kann der Custom-Konstruktor entsprechend vereinfacht
        //          werden: Durch Zugriff auf die neue Eigenschaft Denominator
        //          wird jetzt die Pr�fung auf 0 �ber den setter der Eigenschaft
        //          realisiert. Daher konnte der Custom-Konstruktor aus Aufgabe 06
        //          auskommentiert und hier entsprechend vereinfacht implemen-
        //          tiert werden.
        public Bruch(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        // Implementierung einer Nur-Lese-Eigenschaft Number
        // die den reellen Wert eines Bruchs zur�ckliefert
        public double Number
        {
            get { return (double)numerator / (double)denominator; }
        }

        #endregion
        #region K�rzen von Br�chen
        #region Hilfsmethode ggT
        // Hilfsmethode: ggt, private, da nur in Klasse Bruch verwendet
        // Berechnet den gr��ten gemeinsamen Teiler aus a und b
        private static int ggT(int a, int b)
        {
            while (b != 0)
            {
                int h = a % b;
                a = b;
                b = h;
            }
            return a;
        }

        // Alternative: Rekursive ggT-Berechnung
        private static int ggTRekursiv(int a, int b)
        {
            int rest = a % b;
            if (rest == 0)
                return b;
            else
                return ggTRekursiv(b, rest);
        }
        #endregion

        #region K�rzen als Instanzmethode
        // K�rzt diesen Bruch, �ndert also Z�hler und Nenner
        public void reduce()
        {
            int ggt = Bruch.ggT(this.numerator, this.denominator);
            if (ggt != 1)
            {
                this.numerator /= ggt;
                this.denominator /= ggt;
            }
        }

        // Scheinbar korrekte Alternative (leider falsch, da wir mit
        // Referenztypen arbeiten):
        //(1) public void reduce()
        //(2) {
        //(3)   if (ggT(this.numerator, this.denominator) != 1)
        //(4)   {
        //(5)       this.numerator /= ggT(this.numerator, this.denominator);
        //(6)       this.denominator /= ggT(this.numerator, this.denominator);
        //(7)   }
        //(8) }

        // Beispiel dazu: Sei numerator = 15, denominator = 60
        // Ablauf:
        // (3) ggT(15,60) = 15 und damit != 1, also weiter mit ...
        // (5) this.numerator /= ggT(15, 60) = 15, d.h. 15 / 15 = 1
        // Jetzt beachten: der this.numerator hat sich auf 1 ge�ndert!
        // Jetzt geht es weiter mit genau diesem Wert ...
        // (6) this.denominator /= ggT( 1, 60) =  1, d.h. 60 / 1 = 60
        // Ergebnis w�re 1/60 statt 1/4!!!
        // Daher ist die lokale Variable ggt zwingend erforderlich!
        #endregion

        #region K�rzen als Klassenmethode
        // Liefert den �bergebenen Bruch als neuen Bruch gek�rzt zur�ck
        // Der �bergebene Bruch bleibt unver�ndert
        public static Bruch reduce(Bruch aBruch)
        {
            Bruch copy = new Bruch(aBruch);
            copy.reduce();
            return copy;
        }
        #endregion

        #endregion

        #endregion
    }
}
