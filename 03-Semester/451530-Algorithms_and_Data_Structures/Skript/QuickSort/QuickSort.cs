/* * * * * * *
 * Title:   QuickSort
 * Class:   QuickSort.cs
 * Author:  Bräunlich, Christian
 * Date:    03.01.2019
 * 
*/

#region Library of Alexandria
using System;

#endregion

namespace QuickSort
{
    class QuickSort
    {
        public void quicksort(int[] array)
        {
            quicksort(array, 0, array.Length - 1);
        }

        private void quicksort(int[] array, int first, int last)
        {
            if (first < last)
            {
                int pivot = partition(array, first, last);

                // Recursive call
                quicksort(array, first, pivot - 1);
                quicksort(array, pivot + 1, last);
            }
        }

        private int partition(int[] input, int first, int last)
        {

            /*
            *notice how pivot is randomly selected this makes O(n^2) 
            *very low probability
            */
            int pivot = first + new Random().Next(last - first + 1);

            swap(input, pivot, last);
            for (int i = first; i < last; i++)
            {
                if (input[i] <= input[last])
                {
                    swap(input, i, first);
                    first++;
                }
            }

            swap(input, first, last);
            return first;
        }

        private void swap(int[] input, int a, int b)
        {
            int temp = input[a];
            input[a] = input[b];
            input[b] = temp;
        }

        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
