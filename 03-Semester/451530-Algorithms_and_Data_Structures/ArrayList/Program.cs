/* * * * * * *
 * Title:   ArrayList
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

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList instanziieren
            ArrayList<string> list = new ArrayList<string>(2);

            list.Add("Erster Wert");
            list.Add("Zweiter Wert");
            list.Add("Dritter Wert");
            list.Add("Vierter Wert");
            list.Add(null);
            list.Remove(null);
            list.Remove("Zweiter Wert");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(list);

            Console.WriteLine();
            Console.WriteLine(list.Min);
            Console.WriteLine(list.Max);
            Console.WriteLine();

            Console.WriteLine("Weiter mit ENTER . . .");
            Console.ReadLine();
        }
    }
}
