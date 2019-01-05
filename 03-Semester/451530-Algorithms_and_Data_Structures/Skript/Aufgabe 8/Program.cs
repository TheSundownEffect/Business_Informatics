/* * * * * * *
 * Title:   Aufgabe_8
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

/* * Aufgabenstellung:
 * a) Programmieren Sie zwei Methoden, die die Fakultät für eine 
 *      übergeben Zahl iterativ bzw. rekursiv lösen.
 * 
 *  Die Methodensollten folgende Signatur besitzen:
 *      public static int Factorial(int n)
 * 
 * 
 * b) Programmieren Sie zwei Methoden, die die Position eines
 *      übergebenen Zeichens iterativ bzw. rekursiv suchen.
 *      
 *  Die Methodensollten folgende Signatur besitzen:
 *      public static int IndexOf(string s, char c)
 * 
 * c) Schreiben Sie eine Konsolenanwendung, die für die rekursive
 *      und die iterative IndexOf-Methode die Zeit misst, die die Funktion benötigt.
 * 
 *      Rufen Sie die Methoden mehrmals für eine Zeitmessung mit Zufallsdaten auf.
 * 
 * * */





namespace Aufgabe_8
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        #region Lösung: Aufgabe 8_a)
        public static int Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
                result = result * i;

            return result;
        }
        #endregion

        #region Lösung: Aufgabe 8_b)
        public static int FactorialRecursive(int n, int result = 1)
        {
            if (n == 0)
                return result;

            result = result * n--;

            return FactorialRecursive(n, result);
        }

        // Lösung: Aufgabe 8_b)
        public static int FactorialRecursive(int n)
        {
            if (n == 0)
                return 1;

            return n * FactorialRecursive(n - 1);
        }

        #endregion
    }
}