/* * * * * * *
 * Title:   Summe_eines_Ganzzahl_Wertbereichs_bilden
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

namespace Summe_eines_Ganzzahl_Wertbereichs_bilden
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iteration
            /*
            Function Summe(min, max)

            ergebnis

            while (min <= max)
                            ergebnis += min
              min = min + 1
            end

            return ergebnis
            */

            // Rekursion

            Summe(0, 10);
            Summe(0, int.MaxValue); // Achtung: Stack Overflow!
        }

        public static int Summe(int min, int max, int ergebnis = 0)
        {
            if (min > max)
                return ergebnis;

            ergebnis = ergebnis + min;
            min = min + 1;

            return Summe(min, max, ergebnis);
        }

    }
}
