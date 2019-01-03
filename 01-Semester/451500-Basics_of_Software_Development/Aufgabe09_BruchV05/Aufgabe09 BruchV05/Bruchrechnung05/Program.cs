using System;
using GSE;
using Bruchrechnung;

namespace Bruchrechnung05
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.zeigeTitel("Bruchrechnung - Überladene Operatoren", "Version 5");

            // Ausgangsbrüche in b1 und b2 kopieren, b3 deklarieren, Zahl deklarieren
            Bruch b1 = new Bruch(15, 21);
            Bruch b2 = new Bruch( 7,  8);
            Bruch b3;
            const int ZAHL = 3;

            // Ausgabe der Brüche
            Console.Write("b1 = "); b1.print();
            Console.Write("b2 = "); b2.print();
            Console.WriteLine();

            Console.WriteLine("Test des diadischen Operators -\n");
            // Subtraktion eines Bruchs von einem anderen Bruch mittels Klassenmethode und Ausgabe des Ergebnisses 
            b3 = Bruch.subtract(b1, b2);
            Console.Write("b3 = Bruch.subtract(b1, b2) = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Subtraktion eines Bruchs von einem anderen Bruch mittels überladenem Operator und Ausgabe des Ergebnisses
            b3 = b1 - b2;
            Console.Write("b3 = b1 - b2 = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Ausgabe der Bruchs und der Zahl
            Console.Write("b1 = "); b1.print();
            Console.WriteLine("ZAHL = " + ZAHL);
            Console.WriteLine();

            // Subtraktion einer Zahl von einem Bruch mittels Klassenmethode und Ausgabe des Ergebnisses 
            b3 = Bruch.subtract(b1, ZAHL);
            Console.Write("b3 = Bruch.subtract(b1, ZAHL) = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Subtraktion einer Zahl von einem Bruch mittels Operator und Ausgabe des Ergebnisses 
            b3 = b1 - ZAHL;
            Console.Write("b3 = b1 - ZAHL = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Subtraktion eines Bruchs von einer Zahl mittels Klassenmethode und Ausgabe des Ergebnisses 
            b3 = Bruch.subtract(ZAHL, b1);
            Console.Write("b3 = Bruch.subtract(ZAHL, b1) = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Subtraktion eines Bruchs von einer Zahl mittels Operator und Ausgabe des Ergebnisses 
            b3 = ZAHL - b1;
            Console.Write("b3 = ZAHL - b1 = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            Console.WriteLine("Test des diadischen Operators *\n");
            // Multiplikation eines Bruchs mit einem anderen Bruch mittels Klassenmethode und Ausgabe des Ergebnisses 
            b3 = Bruch.multiply(b1, b2);
            Console.Write("b3 = Bruch.multiply(b1, b2) = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Multiplikation eines Bruchs mit einem anderen Bruch mittels überladenem Operator und Ausgabe des Ergebnisses
            b3 = b1 * b2;
            Console.Write("b3 = b1 * b2 = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Ausgabe der Bruchs und der Zahl
            Console.Write("b1 = "); b1.print();
            Console.WriteLine("ZAHL = " + ZAHL);
            Console.WriteLine();

            // Multiplikation einer Zahl mit einem Bruch mittels Klassenmethode und Ausgabe des Ergebnisses 
            b3 = Bruch.multiply(b1, ZAHL);
            Console.Write("b3 = Bruch.multiply(b1, ZAHL) = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Multiplikation einer Zahl mit einem Bruch mittels Operator und Ausgabe des Ergebnisses 
            b3 = b1 * ZAHL;
            Console.Write("b3 = b1 * ZAHL = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Multiplikation eines Bruchs mit einer Zahl mittels Klassenmethode und Ausgabe des Ergebnisses 
            b3 = Bruch.multiply(ZAHL, b1);
            Console.Write("b3 = Bruch.multiply(ZAHL, b1) = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Multiplikation eines Bruchs mit einer Zahl mittels Operator und Ausgabe des Ergebnisses 
            b3 = ZAHL * b1;
            Console.Write("b3 = ZAHL * b1 = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            Console.WriteLine("Test des diadischen Operators /\n");
            // Division eines Bruchs von einem anderen Bruch mittels Klassenmethode und Ausgabe des Ergebnisses 
            b3 = Bruch.divide(b1, b2);
            Console.Write("b3 = Bruch.divide(b1, b2) = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Division eines Bruchs von einem anderen Bruch mittels überladenem Operator und Ausgabe des Ergebnisses
            b3 = b1 / b2;
            Console.Write("b3 = b1 / b2 = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Ausgabe der Bruchs und der Zahl
            Console.Write("b1 = "); b1.print();
            Console.WriteLine("ZAHL = " + ZAHL);
            Console.WriteLine();

            // Division einer Zahl von einem Bruch mittels Klassenmethode und Ausgabe des Ergebnisses 
            b3 = Bruch.divide(b1, ZAHL);
            Console.Write("b3 = Bruch.divide(b1, ZAHL) = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Division einer Zahl von einem Bruch mittels Operator und Ausgabe des Ergebnisses 
            b3 = b1 / ZAHL;
            Console.Write("b3 = b1 / ZAHL = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Division eines Bruchs von einer Zahl mittels Klassenmethode und Ausgabe des Ergebnisses 
            b3 = Bruch.divide(ZAHL, b1);
            Console.Write("b3 = Bruch.divide(ZAHL, b1) = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();

            // Division eines Bruchs von einer Zahl mittels Operator und Ausgabe des Ergebnisses 
            b3 = ZAHL / b1;
            Console.Write("b3 = ZAHL / b1 = ");
            b3.print();
            b3.dprint();
            Console.WriteLine();


            // Komplexe Ausdrücke mit Brüchen, Ausgabe erfolgt jeweils mit
            // Konversionsoperator string
            // Bei der Ausgabe der gekürzten Brüche muss die Klassenmethode 
            // reduce verwendet werden, da z.B. in (b4 + b1).reduce() 
            // (b4 + b1) keine Instanz ist. Die Klassenmethode dagegen
            // nimmt den Wert des Ausdrucks und liefert ihn gekürzt 
            // (eben via return) zurück.
            Console.WriteLine("Test des mehrgliedriger Ausdrücke\n");
            Bruch b4 = b1 + b2 + b3;
            b4.reduce();
            Console.WriteLine("Bruch b4 = " + b1 + " + " + b2 + " + " + b3 + " = " + b4);
            Console.WriteLine(b4 + " += " + b1 + " = " + Bruch.reduce((b4 += b1)));
            b4.reduce();
            Console.WriteLine(b4 + " -= " + b1 + " = " + Bruch.reduce((b4 -= b1)));
            Console.WriteLine(b1 + " *  " + b2 + " + " + b3 + "  = " + (b1 * b2 + b3));
            Console.WriteLine(b1 + " * (" + b2 + " + " + b3 + ") = " + (b1 * (b2 + b3)));
            Console.WriteLine(b1 + " *  " + b2 + " / " + b3 + "  = " + (b1 * b2 / b3));
            Console.WriteLine(b1 + " * (" + b2 + " / " + b3 + ") = " + (b1 * (b2 / b3)));
            Console.WriteLine(b1 + " / (" + b2 + " - " + b3 + ") = " + (b1 / (b2 - b3)));
            Console.WriteLine(b1 + " /  " + b2 + " - " + b3 + "  = " + (b1 / b2 - b3));

            // Test Gleichheit/Ungleichheit
            Bruch b5 = new Bruch(1, 2);
            Bruch b6 = new Bruch(7, 14);
            Console.WriteLine(b5 == b6);
            Console.WriteLine(b5*b6 == b6*b5);
            Console.WriteLine(b5 != b6);

            Helpers.zeigeProgrammende();
        }
    }
}
