/* * * * * * *
 * Title:   Ermitteln der Komplexitätsklasse
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

namespace Ermitteln_der_Komplexitätsklasse
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCount();

            GetCount2();

            foreach (n1 in werte)            //quadratisch
            {
                foreach (n2 in werte)
                    if (n1 == n2) …
            }

            foreach (n1 in werte)            //polynomial
                foreach (n2 in werte)
                    foreach (n3 in werte)
                        sum += n1 + n2 + n3;

        }

        public static double GetCount(int[] array) //konstant
        {
            return array.Length;
        }

        public static int GetCount2(int[] array)        //linear
        {
            int n = 0;
            foreach (int i in array)
                n++;
            return n;
        }
    }
}
