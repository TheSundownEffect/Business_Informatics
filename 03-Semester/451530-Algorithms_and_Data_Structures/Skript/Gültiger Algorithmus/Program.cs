/* * * * * * *
 * Title:   Gültiger Algorithmus
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


/* Eigenschaften eines Algorithmus 
 * 
 * - Determiniertheit   --> Gleicher Eingabewert muss immer dasselbe Ergebnis liefern!
 * - Determinismus      --> Abfolge der Anweisungen ist eindeutig!
 * - Terminierung       --> Abbruchbedingung muss eintreffen!
 * 
 */


/* Aufgabe 3:
 *  Welche der folgenden C#-Funktionen ist ein gültiger Algorithmus?
 */


/* Aufgabe 4:
 *  Lesen Sie im Lehrbuch S.1 bis 5!
 */

namespace Gültiger_Algorithmus
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Lösung: Aufgabe 3

            // DateTime funktion1()
            //  --> kein gültiger Algorithmus!
            DateTime funktion1()
            {
                return DateTime.Now;
            }

            // int funktion2()
            //  --> kein gültiger Algorithmus!
            int funktion2()
            {
                int i = 0;
                for (; ; )
                    i++;
                return i;
            }

            // int funktion3 (int i = 0)
            //  --> kein gültiger Algorithmus!
            int funktion3(int i = 0)
            {
                while (true)
                    i++;
                return i;
            }

            // int funktion4(int i)
            //  --> kein gültiger Algorithmus!
            int funktion4(int i)
            {
                Random r = new Random(i);
                return r.Next();
            }

            #endregion

            Console.WriteLine(funktion1());
            //Console.WriteLine(funktion2());   --> Endlosschleife
            //Console.WriteLine(funktion3());   --> Endlosschleife
            Console.WriteLine(funktion4(2));

            Console.WriteLine("Weiter mit beliebiger Taste . . .");
            Console.ReadLine();
        }

    }
}
