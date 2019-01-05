using System;
using System.Collections.Generic;

namespace Testklausur2
{
    // 6. Aufgabe

    public static class StackExtension
    {
        public static int GetMaxLength(string[] tempArray)
        {
            string tempString = "";
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempString.Length < tempArray[i].Length)
                {
                    tempString = tempArray[i];
                }
            }

            return tempString.Length;
        }
    }
}
