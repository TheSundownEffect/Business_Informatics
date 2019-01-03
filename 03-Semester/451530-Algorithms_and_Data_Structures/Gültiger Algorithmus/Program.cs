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

namespace Gültiger_Algorithmus
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        DateTime funktion1()
        {
            return DateTime.Now;
        }

        // Endlosschleife!
        int funktion2()
        {
            int i = 0;
            for (; ; )
                i++;
            return i;
        }

        // Endlosschleife!
        int funktion3 (int i = 0)
        {
            while (true)
                i++;
            return i;
        }

        int funktion4(int i)
        {
            Random r = new Random(i);
            return r.Next();
        }
    }
}
