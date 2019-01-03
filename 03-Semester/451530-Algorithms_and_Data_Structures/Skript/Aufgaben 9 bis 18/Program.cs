/* * * * * * *
 * Title:   Vergleich
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

namespace Aufgaben_9_bis_18
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lösung: Aufgabe 9

            #endregion

            #region Lösung: Aufgabe 10

            #endregion

            #region Lösung: Aufgabe 11
            /*
            public T Min
            {
                get
                {
                    if (Count == 0)
                        throw new ArgumentException("0 Element vorhanden");

                    T min = _items[0];

                    for (int i = 0; i < Count; i++)
                    {
                        if (_items[i].CompareTo(min) < 0)
                        {
                            min = _items[i];
                        }
                    }
                    return min;
                }
                
            }
            // - - - - - - - - -

            public T Max
            {
                get
                {
                    if (Count == 0)
                        throw new ArgumentException("0 Element vorhanden");

                    T max = _items[0];

                    for (int i = 0; i < Count; i++)
                    {
                        if (_items[i].CompareTo(max) > 0)
                        {
                            max = _items[i];
                        }
                    }
                    return max;
                }
            }

            */

            #endregion

            #region Lösung: Aufgabe 12

            #endregion

            #region Lösung: Aufgabe 13

            #endregion

            #region Lösung: Aufgabe 14

            #endregion

            #region Lösung: Aufgabe 15

            #endregion


            #region Lösung: Aufgabe 16
            foreach (double d in Pow(2.0, 100.0))
            {
                Console.WriteLine(d);
            }

            #endregion

            #region Lösung: Aufgabe 17


            #endregion

            #region Lösung: Aufgabe 18


            #endregion

            Console.WriteLine("Weiter mit ENTER . . .");
            Console.ReadLine();
        }

        static List<double> Pow(double x, double y)
        {
            var list = new List<double>();
            double v = x;
            for (int i = 0; i < y; i++)
            {
                list.Add(v *= x);
            }
            return list;
        }
    }
}