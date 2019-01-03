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
    class BinarySearch
    {
        public static int binarySearch(int toSearch, int[] array)
        {
            int lowestIndex = 0;
            int highestIndex = array.Length - 1;

            while (lowestIndex <= highestIndex)
            {
                int mid = lowestIndex +
                    (highestIndex - lowestIndex) / 2;

                if (toSearch < array[mid])
                    highestIndex = mid - 1;

                else if (toSearch > array[mid])
                    lowestIndex = mid + 1;

                else if (toSearch == array[mid])
                    return mid;
            }
            return -1;
        }
    }
}
