/* * * * * * *
 * Title:   Stack
 * Class:   StringExtension.cs
 * Author:  Christian B.
 * Date:    02.01.2019
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

namespace myStack
{
    public static class StringExtension
    {
        public static bool IsNumeric(this string s)
        {
            double result;
            return double.TryParse(s, out result);
        }

        public static double CalculateExpression(this string s)
        {
            Stack<double> werte = new Stack<double>();
            Stack<char> operatoren = new Stack<char>();

            string[] teile = s.Split(' ');

            foreach (var teil in teile)
            {
                if (teil.IsNumeric())
                    werte.Push(double.Parse(teil));
                else
                    operatoren.Push(teil[0]);

                if (werte.Count == 2 && operatoren.Count == 1)
                {
                    double wert2 = werte.Pop();
                    double wert1 = werte.Pop();

                    switch (operatoren.Pop())
                    {
                        case '+':
                            werte.Push(wert1 + wert2);
                            break;
                        case '-':
                            werte.Push(wert1 - wert2);
                            break;
                        case '*':
                            werte.Push(wert1 * wert2);
                            break;
                        case '/':
                            werte.Push(wert1 / wert2);
                            break;
                    }
                }
            }
            return werte.Pop();
        }
    }
}
