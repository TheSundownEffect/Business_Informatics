/* * * * * * *
 * Title:   Aufgaben 7 bis 8
 * Class:   Aufgaben 7 bis 8.cs
 * Author:  Christian B.
 * Date:    02.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

/* * * Aufgabenstellung:
 * 
 * Aufgabe 7:
 *  Erstellen Sie eine neue Klasse DoublyLinkedList auf Basisder LinkedList-Klasse
 *  und passen Sie die beiden MethodenAdd und Remove so an, dass der neue Verweis
 *  auf das vorherigeElement effizient genutzt wird.
 *  
 *  Zur Überprüfung, ändern Sie die überschriebene Methode ToString so,
 *  dass zusätzlich die Liste vom last-Knoten beginnend nach vorne ausgegeben wird.
 * 
 * 
 * Aufgabe 8:
 *  Implementieren Sie in der Klasse DoublyLinkedList die Methode InsertAfter.
 * 
 * * */

namespace Aufgaben_7_bis_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // DoublyLinkedList instanziieren
            var list = new DoublyLinkedList<string>();

            list.Add("Erster Wert");
            list.Add("Zweiter Wert");
            list.Add("Dritter Wert");
            list.Add("Vierter Wert");

            list.Remove("Dritter Wert");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(list);

            Console.WriteLine("Weiter mit ENTER . . .");
            Console.ReadLine();
        }
    }
}
