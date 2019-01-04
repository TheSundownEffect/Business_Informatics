/* * * * * * *
 * Title:   BubbleSort
 * Class:   BubbleSort.cs
 * Author:  Bräunlich, Christian
 * Date:    03.01.2019
 * 
*/

#region Library of Alexandria
using System;
using System.Collections.Generic;

#endregion

namespace BubbleSort
{
    public static class BubbleSort
    {
        public static void Bubble_Sort(this IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            collection.BubbleSortAscending(comparer);
        }

        public static void BubbleSortAscending<T>(this IList<T> collection, Comparer<T> comparer)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                for (int index = 0; index < collection.Count - 1; index++)
                {
                    if (comparer.Compare(collection[index], collection[index + 1]) > 0)
                    {
                        collection.Swap(index, index + 1);
                    }
                }
            }
        }

        public static void BubbleSortDescending<T>(this IList<T> collection, Comparer<T> comparer)
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int index = 1; index < collection.Count - i; index++)
                {
                    if (comparer.Compare(collection[index], collection[index - 1]) > 0)
                    {
                        collection.Swap(index - 1, index);
                    }
                }
            }
        }

    }
}