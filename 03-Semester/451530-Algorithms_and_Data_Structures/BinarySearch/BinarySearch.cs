/* * * * * * *
 * Title:   BinarySearch
 * Class:   BinarySearch.cs
 * Author:  Bräunlich, Christian
 * Date:    03.01.2019
 * 
*/

#region Library of Alexandria
using System;

#endregion

namespace BinarySearch
{
    public class BinarySearch
    {
        public static bool binarySearchRecursive(int[] array, int x, int left, int right)
        {
            if (left > right)
            {
                return false;
            }

            int mid = left + ((right - left)) / 2;

            if (array[mid] == x)
                return true;
            else if (x < array[mid])
            {
                return binarySearchRecursive(array, x, left, mid - 1);
            } else
            {
                return binarySearchRecursive(array, x, mid + 1, right);
            }
        }

        public static bool binarySearchIterative(int[] array, int x)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + ((right - left) / 2);
                if (array[mid] == x)
                    return true;
                else if (x < array[mid])
                {
                    right = mid - 1;
                } else
                {
                    left = mid + 1;
                }
            }
            return false;
        }
    }
}
