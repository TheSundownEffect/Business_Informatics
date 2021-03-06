﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace KlausurAuD
{
    public class SortedArrayList<T> : List<T> where T : IComparable
    {
        // Name:
        // Matrikelnr.: 
        //
        // 7. Aufgabe            

        public new int BinarySearchAll(T item)
        {
            int lower = 0;
            int upper = Count - 1;

            while (lower <= upper)
            {
                int mid = lower + (upper - lower) / 2;

                int o = item.CompareTo(this[mid]);

                if (o == 0)
                    return mid;
                if (o > 0)
                    lower = mid + 1;    // oben weitersuchen
                else
                    upper = mid - 1;    // unten weitersuchen
            }
            return ~lower;
        }

        public new int BinarySearch(T item)
        {
            int lower = 0;
            int upper = Count - 1;

            while (lower <= upper)
            {
                int mid = lower + (upper - lower) / 2;

                int o = item.CompareTo(this[mid]);

                if (o == 0)
                    return mid;
                if (o > 0)
                    lower = mid + 1;    // oben weitersuchen
                else
                    upper = mid - 1;    // unten weitersuchen
            }
            return ~lower;
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < Count; i++)
            {
                s += this[i].ToString() + ";";
            }

            return s;
        }
    }

    public static class StackExtension
    {
        public static IEnumerable<T> GreaterThan<T>(this Stack<T> stack, T value) where T : IComparable<T>
        {
            foreach (T item in stack)
                if (value.CompareTo(item) < 0)
                    yield return item;
        }
    }
}