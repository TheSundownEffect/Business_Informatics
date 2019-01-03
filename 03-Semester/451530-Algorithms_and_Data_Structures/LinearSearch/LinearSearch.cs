/* * * * * * *
 * Title:   LinearSearch
 * Class:   LinearSearch.cs
 * Author:  Bräunlich, Christian
 * Date:    03.01.2019
 * 
*/

#region Library of Alexandria
using System;

#endregion

namespace LinearSearch
{
    class LinearSearch
    {
        public static String linearSearch(int[] array, int toSearch)
        {
            String result = "not found";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == toSearch)
                {
                    result = array[i] + " found at position index: " + (i + 1);
                    break;
                }
            }
            return result;
        }
    }
}
