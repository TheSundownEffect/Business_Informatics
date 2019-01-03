/* * * * * * *
 * Title:   Stack
 * Class:   Program.cs
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
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("1.22".IsNumeric());
            Console.WriteLine("3 + 4 * 5".CalculateExpression());
            Console.ReadLine();
            

            Console.WriteLine("Weiter mit ENTER . . .");
            Console.ReadLine();
        }
    }
}
