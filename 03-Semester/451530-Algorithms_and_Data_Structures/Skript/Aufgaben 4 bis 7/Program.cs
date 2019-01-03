/* * * * * * *
 * Title:   Aufgaben 4 bis 7
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

namespace Aufgaben_4_bis_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* * * * Aufgabe 4 * * * */
            int zahl = 4;
            int[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(int i in elements)
            {
                zahl = i ^ 2;
                if (zahl % 100)
                    Console.WriteLine(zahl);
            }
            #region Lösung zu Aufgabe 4
            // 
            #endregion

            /* * * * Aufgabe 5 * * * */
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                if (i % 2)
                    i++;
            }
            #region Lösung zu Aufgabe 5
            // 
            #endregion

            /* * * * Aufgabe 6 * * * */
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                        summe = i + j + k;
                }
            }
            #region Lösung zu Aufgabe 6
            // 
            #endregion

            /* * * * Aufgabe 7 * * * */
            foreach (int i in elements)
            {
                if (i == 3)
                    break;
            }
            #region Lösung zu Aufgabe 7
            // 
            #endregion
        }
    }
}
