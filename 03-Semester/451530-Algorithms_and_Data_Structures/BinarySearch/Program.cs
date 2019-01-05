/* * * * * * *
 * Title:   BinarySearch
 * Class:   Program.cs
 * Author:  Bräunlich, Christian
 * Date:    05.01.2019
 * 
*/

#region Library of Alexandria
using System;

#endregion

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SortedList<int>();
            list.AddRange(new int[] { 7, 3, 5, 9, 4, 1 });
            //list.BubbleSort();
            list.QuickSort();

            Console.WriteLine(list.ToString());

            Console.WriteLine("Weiter mit beliebiger Taste . . .");
            Console.ReadKey();
        }
    }
}
