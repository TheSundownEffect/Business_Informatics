using System;
using GSE;
using Bruchrechnung;

namespace BruchArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.zeigeTitel("Bruchrechnung - Array von Brüchen");
            
            #region 1. Brucharray mit Zufallsbrüchen erzeugen
            const int MAX = 10;
            Console.WriteLine("1. Erzeuge " + MAX + " Zufallsbrüche...");
            // Array mit Referenzvariablen erzeugen
            Bruch[] brueche = new Bruch[MAX];
            // Zufallsszahlengenerator erzeugen (wird mit Zeit initilaisiert)
            Random rnd = new Random();
            // In jeder Referenzvariablen des Array einen 
            // neuen Bruch mit zufälligem Zähler/Nenner mittels
            // Instanzmethode Next(min, max) erzeugen
            for (int i = 0; i < brueche.Length; i++)
                brueche[i] = new Bruch(rnd.Next(1, 10), rnd.Next(1, 10));
            #endregion

            #region 2. Alle Brüche kürzen
            Console.WriteLine("\n2. Kürze alle Zufallsbrüche...");
            foreach (Bruch bruch in brueche)
                bruch.reduce();
            // Alternativ mit for-Schleife
            //for (int i = 0; i < brueche.Length; i++)
            //    brueche[i].reduce();
            // Alternative mit Klassenmethode reduce (Bruch b)
            //for (int i = 0; i < brueche.Length; i++)
            //    brueche[i] = Bruch.reduce(brueche[i]);
            #endregion

            #region 3. Alle Brüche in der Form Zähler / Nenner ausgeben
            Console.WriteLine("\n3. Ausgabe aller Zufallsbrüche...");
            foreach (Bruch bruch in brueche)
                bruch.print();
            // Alternativ durch überladenen Konversionsoperator string
            // foreach (Bruch bruch in brueche)
            //    Console.WriteLine((string)bruch);
            // Alternativ mit for-Schleife
            //for (int i = 0; i < brueche.Length; i++)
            //    brueche[i].print();
            #endregion

            #region 4. Alle Büche als Dezimalzahl ausgeben
            Console.WriteLine("\n4. Ausgabe der Dezimalwerte aller Zufallsbrüche...");
            // Verwendung der Nur-Lese-Eigenschaft Number des Bruchs
            foreach (Bruch bruch in brueche)
                Console.WriteLine(bruch.Number);
            // Alternativ mit for-Schleife
            //for (int i = 0; i < brueche.Length; i++)
            //    Console.WriteLine(brueche[i].Number);
            #endregion

            #region 5. Die Summe aller Brüche bestimmen und ausgeben
            Console.WriteLine("\n5. Summiere alle Zufallsbrüche...");

            Bruch summe = new Bruch();
            foreach (Bruch bruch in brueche)
            {
                summe.add(bruch);
                // Kürzen sinnvoll, da andernfalls sehr große Nenner durch die
                // Multiplikation entstehen können und ggfs. der Wertebereich
                // für int überschritten werden könnte.
                // summe.reduce();
            }
            
            // Alternativ: Nutzung des in Bruchklasse überladenen Operators +
            //Bruch summe = new Bruch();
            //foreach (Bruch bruch in brueche)
            //{
            //    summe += bruch;
            //    summe.reduce();
            //}
            
            // Alternativ mit for-Schleife
            //Bruch summe = new Bruch();
            //for (int i = 0; i < brueche.Length; i++)
            //{
            //     summe.add(brueche[i]); // oder summe += brueche[i];
            //     summe.reduce();
            //}
            
            // Alternativ mit Copy-Konstruktor und for-Schleife
            //Bruch summe = new Bruch(brueche[0]);
            //for (int i = 1; i < brueche.Length; i++)
            //{
            //    summe.add(brueche[i]); // oder summe += brueche[i];
            //    summe.reduce();
            //}

            Console.WriteLine("Summe aller Zufallsbrüche...");
            summe.print();
            summe.dprint();
            #endregion

            #region 6. Die Summe aller Brüche kürzen und ausgeben
            Console.WriteLine("\n6. Gekürzte Summe alle Zufallsbrüche...");
            summe.reduce();
            summe.print();
            summe.dprint();
            #endregion

            Helpers.zeigeProgrammende();
        }
    }
}
