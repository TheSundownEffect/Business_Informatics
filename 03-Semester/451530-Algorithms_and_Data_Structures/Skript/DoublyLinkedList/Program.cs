/* * * * * * *
 * Title:   DoublyLinkedList
 * Class:   Program.cs
 * Author:  Christian B.
 * Date:    01.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace DoublyLinkedList
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
