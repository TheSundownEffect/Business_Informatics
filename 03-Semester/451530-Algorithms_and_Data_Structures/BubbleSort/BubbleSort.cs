/* * * * * * *
 * Title:   BubbleSort
 * Class:   BubbleSort.cs
 * Author:  Bräunlich, Christian
 * Date:    03.01.2019
 * 
*/

#region Library of Alexandria
using System;

#endregion

namespace BubbleSort
{
    class BubbleSort
    {
        public static void Bubble_Sort(int[] a)
        {
            int temp = 0;

            for (int write = 0; write < a.Length; write++)
            {
                for (int sort = 0; sort < a.Length - 1; sort++)
                {
                    if (a[sort] > a[sort + 1])
                    {
                        temp = a[sort + 1];
                        a[sort + 1] = a[sort];
                        a[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
        }
    }
}
