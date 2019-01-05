
/* * * * * * *
 * Title:   BinarySearch
 * Class:   SortedList.cs
 * Author:  Bräunlich, Christian
 * Date:    05.01.2019
 * 
*/

#region Library of Alexandria
using System;
using System.Collections.Generic;

#endregion

namespace BinarySearch
{
    public class SortedList<T> : List<T> where T : IComparable<T>
    {
        public void QuickSort()
        {
            QSort(0, Count - 1);
        }
        void QSort(int untereGrenze, int obereGrenze)
        {
            if (untereGrenze >= obereGrenze)
                return;
            int pivot = (untereGrenze + obereGrenze) / 2;
            int teiler = Teile(untereGrenze, obereGrenze, pivot);

            QSort(untereGrenze, teiler - 1);
            QSort(teiler + 1, obereGrenze);
        }
        int Teile(int untereGrenze, int obereGrenze, int pivot)
        {
            T pivotWert = this[pivot];
            int teiler = untereGrenze;
            Swap(pivot, obereGrenze);
            for (int i = untereGrenze; i < obereGrenze; i++)
            {
                if (this[i].CompareTo(pivotWert) < 0)
                {
                    Swap(i, teiler);
                    teiler++;
                }
            }
            Swap(obereGrenze, teiler);
            return teiler;
        }

        public int BinSearch(T value)
        {
            int lower = 0;
            int upper = Count - 1;
            int mid;
            while (upper - lower >= 0)
            {
                mid = (upper + lower) / 2;
                int c = value.CompareTo(this[mid]);

                if (c == 0)
                    return mid;
                if (c < 0)
                    upper = mid - 1;
                else
                    lower = mid + 1;
            }
            return ~lower;
        }

        public void BubbleSort()
        {
            bool getauscht = true;
            while (getauscht == true)
            {
                getauscht = false;
                int count = Count - 1;
                for (int i = 0; i < count; i++)
                {
                    int c = this[i].CompareTo(this[i + 1]);
                    if (c > 0)
                    {
                        Swap(i, i + 1);
                        getauscht = true;
                    }
                }
                count--;
            }
        }
        void Swap(int i1, int i2)
        {
            T item = this[i1];
            this[i1] = this[i2];
            this[i2] = item;
        }
        public override string ToString()
        {
            string temp = "";
            foreach (var item in this)
            {
                temp += item + " ";
            }

            return temp;
        }
    }
}
