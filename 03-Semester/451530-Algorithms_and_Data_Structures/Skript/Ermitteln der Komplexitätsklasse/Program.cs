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
            int[] myTempArray = new int[] { 1, 4, 9, 10 };
            GetCount(myTempArray);

            GetCount2(myTempArray);

            int sum = 0;
            foreach (var n1 in myTempArray)            //quadratisch
            {
                foreach (var n2 in myTempArray)
                    if (n1 == n2)
                        sum += n1 + n2 + n3;
            }
            Console.WriteLine(sum);

            sum = 0;
            foreach (var n1 in myTempArray)            //polynomial
                foreach (var n2 in myTempArray)
                    foreach (var n3 in myTempArray)
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
