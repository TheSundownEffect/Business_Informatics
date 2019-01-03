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
 * Version 02 (Aufgabe 07)
 * - Instanzmethoden Bruchaddition, -multiplikation, [-subtraktion, -division]
 * - Klassenmethoden Bruchaddition, -multiplikation, [-subtraktion, -division]
 * 
 * Version 03 (Aufgabe 08)
 * - Eigenschaften eines Bruchs mit getter-/setter-Methoden
 * - Nur-Lese-Eigenschaft double Number
 * - Instanz- und Klassenmethode zum Kürzen eines Bruchs
 * 
 * Version 04 (Beispielprojekt Überladene Operatoren)
 * - Überladen von Operatoren für Brüche (hier monadisch - und diadisch +, Konversion)
 *
 * Version 05 (Aufgabe 09)
 * - Überladen von Operatoren für Brüche (diadisch -, * /)
 * 
 * Version 06 (Aufgabe 11)
 * - Eingabe von Brüchen mit Fehlerbehandlung
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
        // Instanzvariable zähler und nenner für einen Bruch
        // Beide sind private, da sie nur durch den Konstruktor
        // und unter seiner Kontrolle gesetzt werden dürfen.
        private int numerator;
        private int denominator;
        // Die ergänzten Eigenschaften finden Sie ausnahmsweise
        // mal unten in der Region der Aufgabe 08
        #endregion

        #region Überladene Konstruktoren
        // Customkonstruktor
        // erzeugt einen neuen Bruch aus übergebenem numerator und 
        // denominator und prüft dabei, ob denominator != 0 ist!
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


        // Überladener Customkonstruktor
        // Erzeugt Bruch aus übergebener Ganzzahl als numerator 
        // und 1 als denominator (36 = 36 / 1)
        // Hier mit obigem Customkonstruktor verkettet
        public Bruch(int zahl) : this(zahl, 1)
        {
            // Ohne Verkettung müssten hier die Werte gesetzt werden:
            // this.numerator = zahl;
            // this.denominator = 1;
        }

        // Defaultkonstruktor: Erzeugt neuen Bruch als 0 / 1.
        // Damit ist ein Bruch wie jeder einfache numerische
        // Datentyp mit dem Defaultwert 0 initialisiert.
        // Hier mit obigem Customkonstruktor verkettet
        public Bruch() : this(0, 1)
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

        #region Addition eines Bruch oder einer Zahl zu diesem Bruch (Instanzmethoden)
        // Addition eines Bruch zu dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird geändert
        public void add(Bruch aBruch)
        {
            this.numerator = this.numerator * aBruch.denominator
                           + this.denominator * aBruch.numerator;
            this.denominator = this.denominator * aBruch.denominator;
        }

        // Addition einer Zahl zu dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird geändert
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
            // Alternativ: aBruchLeft kopieren, zur Kopie aBruchRight unter
            //             Verwendung der Instanzmethode addieren
            //             und zurückliefern (aBruchLeft dadurch unverändert!)
            // Bruch copy = new Bruch (aBruchLeft);
            // copy.add(aBruchRight);
            // return copy;
        }

        // Addition eines Bruchs und einer Zahl 
        // Liefert das Ergebnis als neuen Bruch zurück
        public static Bruch add(Bruch aBruch, int aZahl)
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

        #region Multiplikation dieses mit einem anderen Bruch oder einer Zahl (Instanzmethoden)
        // Multiplikation dieses mit einem anderen Bruch
        // Ändert den Wert dieses Bruchs
        public void multiply(Bruch aBruch)
        {
            this.numerator *= aBruch.numerator;
            this.denominator *= aBruch.denominator;
        }

        // Multiplikation dieses Bruchs mit einer Zahl
        // Ändert den Wert dieses Bruchs
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
            // Alternativ: aBruchLeft kopieren, diese mit aBruchRight
            // multiplizieren und das Erebnis zurückliefern:
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

        #region Subtraktion eines Bruchs oder einer Zahl von diesem Bruch (Instanzmethoden)
        // Subtraktion eines Bruchs von dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird geändert
        public void subtract(Bruch aBruch)
        {
            this.numerator = this.numerator * aBruch.denominator
                           - this.denominator * aBruch.numerator;
            this.denominator = this.denominator * aBruch.denominator;
        }

        // Subtraktion einer Zahl von dieser Bruchinstanz
        // Der Wert dieser Bruchinstanz wird geändert
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
            // Alternativ: aBruchLeft kopieren, von diesee aBruchRight
            // abziehen und das Ergebnis zurückliefern:
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

        #region Division dieses durch einen anderen Bruch oder eine Zahl (Instanzmethoden)
        // Division dieses durch einen anderen Bruch
        // Verfahren: Multiplikation mit dem Kehrwert, da andernfalls bei 
        //            Ganzzahlen Problem der Ganzzahldivision auftritt!
        // Ändert den Wert dieses Bruchs
        public void divide(Bruch aBruch)
        {
            this.numerator *= aBruch.denominator;
            this.denominator *= aBruch.numerator;
        }

        // Division dieses Bruchs durch eine Zahl
        // Verfahren: Multiplikation mit dem Kehrwert, da andernfalls bei 
        //            Ganzzahlen Problem der Ganzzahldivision auftritt!
        // Ändert den Wert dieses Bruchs
        public void divide(int aZahl)
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
            // Alternativ: aBruchLeft kopieren, durch aBruchRight
            // dividieren und das Erebnis zurückliefern:
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
        // Zur Beachtung: Dekaration der beiden Instanzvariable int numerator und 
        // int denominator oben in Version01 bereits deklariert
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
        //          wird jetzt die Prüfung auf 0 über den setter der Eigenschaft
        //          realisiert. Daher konnte der Custom-Konstruktor aus Aufgabe 06
        //          auskommentiert und hier entsprechend vereinfacht implemen-
        //          tiert werden.
        public Bruch(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        // Implementierung einer Nur-Lese-Eigenschaft Number
        // die den reellen Wert eines Bruchs zurückliefert
        public double Number
        {
            get { return (double)numerator / (double)denominator; }
        }

        #endregion

        #region Kürzen von Brüchen
        #region Hilfsmethode ggT
        // Hilfsmethode: ggt, private, da nur in Klasse Bruch verwendet
        // Berechnet den größten gemeinsamen Teiler aus a und b
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

        #region Kürzen als Instanzmethode
        // Kürzt diesen Bruch, ändert also Zähler und Nenner
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
        // Jetzt beachten: der this.numerator hat sich auf 1 geändert!
        // Jetzt geht es weiter mit genau diesem Wert ...
        // (6) this.denominator /= ggT( 1, 60) =  1, d.h. 60 / 1 = 60
        // Ergebnis wäre 1/60 statt 1/4!!!
        // Daher ist die lokale Variable ggt zwingend erforderlich!
        #endregion

        #region Kürzen als Klassenmethode
        // Liefert den übergebenen Bruch als neuen Bruch gekürzt zurück
        // Der übergebene Bruch bleibt unverändert
        public static Bruch reduce(Bruch aBruch)
        {
            Bruch copy = new Bruch(aBruch);
            copy.reduce();
            return copy;
        }
        #endregion

        #endregion

        #endregion

        #region Version 04 - Beispielprojekt überladene Operatoren, Konversionsoperatoren
        // Implementierung eines überladenen monadischen Operators -
        // für die Bruchrechnung (monadisch + macht wenig Sinn)
        public static Bruch operator -(Bruch a)
        {
            //int numerator = a.numerator * b.denominator + b.numerator * a.denominator;
            //int denominator = a.denominator * b.denominator;
            //Bruch x = new Bruch(numerator, denominator);
            //return x;
            //oder viel einfacher:
            return new Bruch(-a.numerator, a.denominator);
        }

        // Implementierung eines überladenen diadischen Operators +
        // für die Bruchrechnung
        public static Bruch operator +(Bruch a, Bruch b)
        {
            //int numerator = a.numerator * b.denominator + b.numerator * a.denominator;
            //int denominator = a.denominator * b.denominator;
            //Bruch x = new Bruch(numerator, denominator);
            //return x;
            //oder viel einfacher durch Zurückführung auf Klassenmethode:
            return Bruch.add(a, b);
        }

        // Implementierung eines überladenen diadischen Operators +
        // für die Bruchrechnung
        public static Bruch operator +(Bruch a, int zahl)
        {
            return a + new Bruch(zahl);
        }

        // Implementierung eines überladenen diadischen Operators +
        // für die Bruchrechnung
        public static Bruch operator +(int zahl, Bruch a)
        {
            return new Bruch(zahl) + a;
        }

        // Implementierung eines überladenen diadischen Operators >
        // für die Bruchrechnung
        public static bool operator >(Bruch a, Bruch b)
        {
            // Brüche gleichnamig machen und Zähler vergleichen
            int links = a.numerator * b.denominator;
            int rechts = b.numerator * a.denominator;
            return links > rechts;
        }

        // Implementierung eines überladenen diadischen Operators >
        // für die Bruchrechnung
        public static bool operator <(Bruch a, Bruch b)
        {
            // Brüche gleichnamig machen und Zähler vergleichen
            int links = a.numerator * b.denominator;
            int rechts = b.numerator * a.denominator;
            return links < rechts;
        }

        // Implementierung Konversionsoperator Zahl -> Bruch
        // Aufruf: Bruch bruch = 17;
        public static implicit operator Bruch(int zahl)
        {
            return new Bruch(zahl, 1);
        }

        // Implementierung Konversionsoperator Bruch -> Ganzzahl
        // Aufruf: int i = bruch
        public static implicit operator int(Bruch b)
        {
            return b.numerator / b.denominator;
        }

        // Implementierung Konversionsoperator Bruch -> reelle Zahl
        // Aufruf: double d = (double)bruch
        public static implicit operator double(Bruch b)
        {
            return (double)b.numerator / (double)b.denominator;
        }

        // Implementierung Konversionsoperator Bruch -> string
        // Aufruf: string s = bruch oder Console.WriteLine(bruch)
        public static implicit operator string(Bruch b)
        {
            return b.numerator + "/" + b.denominator;
        }

        #endregion

        #region Version 05 - Aufgabe 09

        #region Überladen Operator -
        // Überladen des Operators -
        // Kann auf die Operation Addition mit monadischem Operator - 
        // oder auf die Klassen- oder Instanzmethode subtract zurückgeführt werden
        public static Bruch operator -(Bruch a, Bruch b)
        {
            return a + -b;                 // Verwendung monadischer Operator -
            //return Bruch.subtract(a, b); // Verwendung Klassenmethode
            //Bruch copy = new Bruch(a);   // Verwendung Instanzmethode
            //copy.subtract(b);            //           "
            //return copy;                 //           "
        }

        // Kann bspw. unmittelbar auf die Subtraktion zweier Brüche 
        // zurückgeführt werden, wenn aus Zahl ein Bruch erzeugt wird
        public static Bruch operator -(Bruch a, int zahl)
        {
            return a - new Bruch(zahl);
        }

        // Kann bspw. unmittelbar auf die Subtraktion zweier Brüche 
        // zurückgeführt werden, wenn aus Zahl ein Bruch erzeugt wird
        public static Bruch operator -(int zahl, Bruch a)
        {
            return new Bruch(zahl) - a;
        }

        #endregion

        #region Überladen Operator *
        // Überladen des Operators *
        // Kann bspw. auf die Klassen- oder Istanzmethode multiply zurückgeführt werden
        public static Bruch operator *(Bruch a, Bruch b)
        {
            return Bruch.multiply(a, b); // Verwendung Klassenmethode
            //Bruch copy = new Bruch(a); // Verwendung Instanzmethode
            //copy.multiply(b);          //           "
            //return copy;               //           "
        }

        // Kann bspw. auf die Multiplikation zweier Brüche mit * zurückgeführt 
        // werden, wobei vorher aus der Zahl ein Bruch erzeugt wird
        public static Bruch operator *(Bruch a, int zahl)
        {
            return a * new Bruch(zahl);
        }

        // Kann bspw. auf die Multiplikation zweier Brüche mit * zurückgeführt 
        // werden, wobei vorher aus der Zahl ein Bruch erzeugt wird
        public static Bruch operator *(int zahl, Bruch a)
        {
            return new Bruch(zahl) * a;
        }

        #endregion

        #region Überladen Operator /
        // Überladen des Operators /
        // Kann bspw. auf die Klassen- oder Instanzmethode divide zurückgeführt werden
        public static Bruch operator /(Bruch a, Bruch b)
        {
            return Bruch.divide(a, b);
            //Bruch copy = new Bruch(a);
            //copy.divide(b);
            //return copy;
        }

        // Überladen des Operators /
        // Kann bspw. auf den Operator / zurückgeführt werden,
        // wobei aus der Zahl vorher ein Bruch erzeugt wird
        public static Bruch operator /(Bruch a, int zahl)
        {
            return a / new Bruch(zahl);
        }

        // Überladen des Operators /
        // Kann bspw. auf den Operator / zurückgeführt werden,
        // wobei aus der Zahl vorher ein Bruch erzeugt wird
        public static Bruch operator /(int zahl, Bruch a)
        {
            return new Bruch(zahl) / a;
        }

        #endregion

        #endregion

        #region Version 06 - Aufgabe 10 (Fehlerbehandlung)

        public static Bruch readBruch()
        {
            int numerator = 0;  // lokale Variable für den Zähler
            string input = "";  // Eingabeversuch, ermöglicht Anzeige der Eingabe nach Fehler
            bool ok = false;    // Bisher keine fehlerfreie Eingabe
            while (!ok)         // solange keine fehlerfreie Eingabe, auch mit do..while möglich
            {
                try
                {
                    Console.Write("Zähler: ");          // Eingabeaufforderung Zähler
                    input = Console.ReadLine();         // Einlesen ggfs. fehlerhafter Zähler
                    numerator = Convert.ToInt32(input); // Versuch, Umwandlung der Eingabe
                    ok = true;                          // bei Erfolg der Uwandlung ist ok true
                }                                       // sonst bleibt ok false
                catch (Exception ex)
                {
                    Console.WriteLine("Zählereingabe {0} liefert: {1}", input, ex.Message);
                    ok = false;
                }
            }

            int denominator = 1;// lokale Variable für Nenner
            ok = false;         // Zunächst wieder nicht fehlerfrei
            while (!ok)         // solange keine fehlerfreie Einbgabe                
            {
                try
                {
                    Console.Write("Nenner: ");          // Eingabeaufforderung Nenner
                    input = Console.ReadLine();         // Einlesen ggfs. fehlerhafter Nenner
                    denominator = Convert.ToInt32(input); // Versuch, Umwandlung der Eingabe
                                                        // gfs. hier Konvertierungsfehler
                    if (denominator == 0)               // wenn ok, könnte Nenner == 0 sein 
                    {
                        ok = false;                             // Eingabe war fehlerhaft
                        throw new Exception("Nenner darf nicht 0 sein!");   // Fehler werfen
                    }
                    ok = true;				// bei Erfolg der Uwandlung ist ok true
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nennereingabe {0} liefert: {1}", input, ex.Message);
                }
            }
            Console.WriteLine();
            return new Bruch(numerator, denominator);   // Neuen Bruch mit Zähler und Nenner zurückliefern
        }

        #endregion
    }
}
