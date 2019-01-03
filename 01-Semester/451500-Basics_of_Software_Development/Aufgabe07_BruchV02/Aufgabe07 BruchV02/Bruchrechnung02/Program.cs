using System;
using GSE;
using Bruchrechnung;

namespace Bruchrechnung02
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.zeigeTitel("Bruchrechnung", "Version 2");

            // Konstante des Beispiels für zwei Brüche deklarieren
            // Wenn andere Zahlen getestet werden sollen, bitte hier ändern:
            const int ZAEHLERB1 = 3, NENNERB1 = 8;
            const int ZAEHLERB2 = 1, NENNERB2 = 7;

            #region Bruchaddition testen
            // Zwei Bruchinstanzen unter Verwendung obiger Konstanten erzeugen
            Bruch b1 = new Bruch(ZAEHLERB1, NENNERB1);
            Bruch b2 = new Bruch(ZAEHLERB2, NENNERB2);

            // Bruchinstanzen ausgeben
            Console.Write("Bruch b1 = new Bruch(" + ZAEHLERB1 + ", " + NENNERB1 +"): "); 
            b1.print();
            Console.Write("Bruch b2 = new Bruch(" + ZAEHLERB2 + ", " + NENNERB2 + "): ");
            b2.print();

            Console.WriteLine("\nTest der Bruchaddition (Klassenmethoden)...");
            Bruch b3 = Bruch.add(b1, b2);
            Console.Write("Bruch b3   = Bruch.add(b1, b2) = "); b3.print();
            b3 = Bruch.add(b1, 5);
            Console.Write("      b3   = Bruch.add(b1,  5) = "); b3.print();
            b3 = Bruch.add( 5, b2);
            Console.Write("      b3   = Bruch.add( 5, b2) = "); b3.print();
            Console.WriteLine("\nTest der Bruchaddition (Instanzmethoden)...");
            b1.add(b2);
            Console.Write("b1.add(b2) = "); b1.print();
            b1.add(5);
            Console.Write("b1.add( 5) = "); b1.print();
            #endregion

            #region Bruchmultiplikation testen
            // Bruchinstanzen b1 und b2 mit Ursprungswerten erzeugen
            b1 = new Bruch(ZAEHLERB1, NENNERB1);
            b2 = new Bruch(ZAEHLERB2, NENNERB2);

            // Bruchinstanzen ausgeben
            Console.Write("\n      b1 = new Bruch(" + ZAEHLERB1 + ", " + NENNERB1 + "): ");
            b1.print();
            Console.Write("      b2 = new Bruch(" + ZAEHLERB2 + ", " + NENNERB2 + "): ");
            b2.print();
            
            Console.WriteLine("\nTest der Bruchmultiplikation (Klassenmethoden)...");
            b3 = Bruch.multiply(b1, b2);
            Console.Write("      b3   = Bruch.multiply(b1, b2) = "); b3.print();
            b3 = Bruch.multiply(b1, 5);
            Console.Write("      b3   = Bruch.multiply(b1,  5) = "); b3.print();
            b3 = Bruch.multiply(5, b2);
            Console.Write("      b3   = Bruch.multiply( 5, b2) = "); b3.print();
            Console.WriteLine("\nTest der Bruchmultiplikation (Instanzmethoden)...");
            b1.multiply(b2);
            Console.Write("b1.multiply(b2) = "); b1.print();
            b1.multiply(5);
            Console.Write("b1.multiply( 5) = "); b1.print();
            #endregion

            #region Bruchsubtraktion testen
            // Bruchinstanzen b1 und b2 mit Ursprungswerten erzeugen
            b1 = new Bruch(ZAEHLERB1, NENNERB1);
            b2 = new Bruch(ZAEHLERB2, NENNERB2);

            // Bruchinstanzen ausgeben
            Console.Write("\n      b1 = new Bruch(" + ZAEHLERB1 + ", " + NENNERB1 + "): ");
            b1.print();
            Console.Write("      b2 = new Bruch(" + ZAEHLERB2 + ", " + NENNERB2 + "): ");
            b2.print();

            Console.WriteLine("\nTest der Bruchsubtraktion (Klassenmethoden)...");
            b3 = Bruch.subtract(b1, b2);
            Console.Write("      b3   = Bruch.subtract(b1, b2) = "); b3.print();
            b3 = Bruch.subtract(b1, 5);
            Console.Write("      b3   = Bruch.subtract(b1,  5) = "); b3.print();
            b3 = Bruch.subtract(5, b1);
            Console.Write("      b3   = Bruch.subtract( 5, b1) = "); b3.print();
            Console.WriteLine("\nTest der Bruchsubtraktion (Instanzmethoden)...");
            b1.subtract(b2);
            Console.Write("b1.subtract(b2) = "); b1.print();
            b1.subtract(5);
            Console.Write("b1.subtract( 5) = "); b1.print();
            #endregion

            #region Bruchdivision testen
            // Bruchinstanzen b1 und b2 mit Ursprungswerten erzeugen
            b1 = new Bruch(ZAEHLERB1, NENNERB1);
            b2 = new Bruch(ZAEHLERB2, NENNERB2);

            // Bruchinstanzen ausgeben
            Console.Write("\n      b1 = new Bruch(" + ZAEHLERB1 + ", " + NENNERB1 + "): ");
            b1.print();
            Console.Write("      b2 = new Bruch(" + ZAEHLERB2 + ", " + NENNERB2 + "): ");
            b2.print();

            Console.WriteLine("\nTest der Bruchdivision (Klassenmethoden)...");
            b3 = Bruch.divide(b1, b2);
            Console.Write("      b3   = Bruch.divide(b1, b2) = "); b3.print();
            b3 = Bruch.divide(b1, 5);
            Console.Write("      b3   = Bruch.divide(b1,  5) = "); b3.print();
            b3 = Bruch.divide(5, b2);
            Console.Write("      b3   = Bruch.divide( 5, b2) = "); b3.print();
            Console.WriteLine("\nTest der Bruchdivision (Instanzmethoden)...");
            b1.divide(b2);
            Console.Write("b1.divide(b2) = "); b1.print();
            b1.divide(5);
            Console.Write("b1.divide( 5) = "); b1.print();
            #endregion

            Helpers.zeigeProgrammende();
        }
    }
}
