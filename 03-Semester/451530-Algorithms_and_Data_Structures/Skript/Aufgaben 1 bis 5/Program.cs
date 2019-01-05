/* * * * * * *
 * Title:   Aufgaben 1 bis 7
 * Class:   Program.cs
 * Author:  Christian B.
 * Date:    01.01.2019
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

/* * * Aufgabenstellung:

Aufgabe 1:
    Ändern Sie den Quellcode zu Remove so, dass der "previousNode" nur ermittelt wird,
    wenn das zu löschende Element nicht das erste ist!

Aufgabe 2:
    Erstellen Sie in der bisher erzeugten Klasse LinkedList einen Index
    zum Zugriff auf einzelne Werte. Setzen Sie dazu den Zugriffmodifizierer
    der Methode FindByIndex auf private und verwenden diese Methode in der
    get- und set-Methode des Indexer.

Aufgabe 3:
    Schreiben Sie ein Programm zum Testen der bisher erstellten Methoden
    der Klasse LinkedList. Fügen Sie zunächst 10 Datensätze ein und geben Sie
    diese danach in einer for-Schleife wieder aus.

Aufgabe 4:
    Ändern Sie die Aufgabe 3 so ab, dass eine foreach-Schleifeverwendet wird.
    Durchlaufen Sie danach die Elemente noch einmal,
    indem Sie direkt die GetEnumerator-Methode aufrufen und
    die Methoden/Eigenschaften des zurückgegebenen Objekts verwenden.

Aufgabe 5:
    Implementieren Sie in der Klasse LinkedList eine Methode Clear, 
    die alle Elemente aus der Liste löscht.

Aufgabe 6:
    Ändern Sie die LinkedList-Klasse so, dass generische Typen verwendet werden können.

Aufgabe 7:

    Welches Ergebnis liefert folgender C#-Code?

       public class A<T>
        {
            public class B : A<int>
            {
                public void M()
                {
                    Console.WriteLine(typeof(T));
                }
                public class C : B { }
            }
        }

        public class P
        {
            public static void Main()
            {
                new A<string>.B.C().M();
            }
        }

* * */

namespace Aufgaben_1_bis_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkedList instanziieren
            var list = new LinkedList<string>();

            #region Lösung: Aufgabe 3
            list.Add("Erster Wert");
            list.Add("Zweiter Wert");
            list.Add("Dritter Wert");
            list.Add("Vierter Wert");
            list.Add("Fünfter Wert");
            list.Add("Sechster Wert");
            list.Add("Siebter Wert");
            list.Add("Achter Wert");
            list.Add("Neunter Wert");
            list.Add("Zehnter Wert");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(i + " -> ");
            }

            #endregion


            #region Lösung: Aufgabe 4
            IEnumerator iterator = list.GetEnumerator();

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
            //iterator.Reset();

            foreach (string name in list)
                Console.WriteLine(name);

            #endregion


            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            #region Lösung: Aufgabe 7
            new A<string>.B.C().M();

            #endregion


            Console.WriteLine(list);

            Console.WriteLine("Weiter mit ENTER . . .");
            Console.ReadLine();
        }

        public class A<T>
        {
            public class B : A<int>
            {
                public void M()
                {
                    Console.WriteLine(typeof(T));
                }
                public class C : B { }
            }
        }
    }
}
