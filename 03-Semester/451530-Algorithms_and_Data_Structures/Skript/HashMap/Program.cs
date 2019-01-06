/* * * * * * *
 * Title:   HashMap
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

namespace HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipCodes zipCodes = new ZipCodes(@"C:\GitHub\Business_Informatics\03-Semester\451530-Algorithms_and_Data_Structures\Skript\_Testdaten\ZipCodes.csv");
            zipCodes.ReadData();

            while (true)
            {
                Console.Write("Zipcode: ");
                string code = Console.ReadLine();

                ZipCodes.Zip zip = zipCodes.Search(code);
                if (zip == null)
                    Console.WriteLine("Ort nicht gefunden");
                else
                    Console.WriteLine(zip);

                Console.WriteLine("Weiter mit ENTER . . .");
                Console.ReadLine();
            }
        }
    }
}
