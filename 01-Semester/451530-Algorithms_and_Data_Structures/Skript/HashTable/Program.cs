/* * * * * * *
 * Title:   HashTable
 * Class:   Program.cs
 * Author:  Christian B.
 * Date:    02.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var plz = new HashTable<int, string>();
            plz.Add(24943, "Flensburg");
            plz.Add(25355, "Barmstedt");
            plz.Add(25746, "Heide");

            Console.WriteLine(plz.Contains(25355));
            plz.Remove(25355);
            Console.WriteLine(plz.Contains(25355));

            foreach (var item in plz)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            // Einwohner[Schleswig-Holstein] = 2838000;

            // Implementierung --> Probleme:
            // 1. Speicherverwaltung
            // 2. vom Indexer String zum Indexer Zahl
            // Abbilden nicht-numerischer Werte

            // Abbilden einer großen Wertmenge durch sog. Hashfunktion

            // Für Hashfunktionen --> "modulo" !

            // Problem der Kollision
            // Hashtabelle --> List
            // oder auch Lineares Sondieren (Achtung: sehr leichte Klumpenbildung!)
            // oder sogar Quadratische Sondierung
            // 2 Funktionen (Schrittweite-Berechnung)
            // 1. Berechnen Array-Index
            // 2. Schrittweite beim Einfügen/Suchen
            // hashSteps = Konstante - (Hashkey mod Konstante)

            // Wichtig Länge entsprechend setzen, damit nicht zu viele Kollisionen zustande kommen








            Console.WriteLine("Weiter mit ENTER . . .");
            Console.ReadLine();
        }
    }
}
