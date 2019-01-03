/* * * * * * *
 * Title:   BinaryTree
 * Class:   Program.cs
 * Author:  Christian B.
 * Date:    02.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\GitHub\WI\Algo\Testdaten\ZIPCodes.csv";

            using (var reader = new StreamReader(filePath, Encoding.Default))
            {

            }

            var tree = new BinaryTree<int, string>();
            tree.Add(23000, "Flensburg");
            tree.Add(22000, "Suederstapel");
            tree.Add(24000, "Heide");
            tree.Add(26000, "Meyn");
            tree.Add(25000, "Witzwort");
            tree.Add(27000, "Dach");


            Console.WriteLine(tree.Max);
            Console.WriteLine(tree.Min);
            Console.WriteLine(tree);

            if (tree.Contains(21000))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.WriteLine("Weiter mit ENTER . . .");
            Console.ReadLine();
        }
    }
}
