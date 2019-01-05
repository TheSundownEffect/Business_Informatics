/* * * * * * *
 * Title:   ArrayList
 * Class:   ArrayList.cs
 * Author:  Christian B.
 * Date:    01.01.2019
 * 
* * */

#region Bibliothek von Alexandria
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace ArrayList
{
    class ArrayList<T> : IEnumerable where T : IComparable<T>
    {
        public int Count { get; private set; }
        T[] _items;

        public ArrayList(int size = 100)
        {
            _items = new T[size];
        }

        public T Min
        {
            get
            {
                if (Count == 0)
                    throw new ArgumentException("0 Element vorhanden");

                T min = _items[0];

                for (int i = 0; i < Count; i++)
                {
                    if (_items[i].CompareTo(min) < 0)
                    {
                        min = _items[i];
                    }
                }
                return min;
            }
        }

        public T Max
        {
            get
            {
                if (Count == 0)
                    throw new ArgumentException("0 Element vorhanden");

                T max = _items[0];

                for (int i = 0; i < Count; i++)
                {
                    if (_items[i].CompareTo(max) > 0)
                    {
                        max = _items[i];
                    }
                }
                return max;
            }
        }


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _items[i];
            }
        }

        public void Add(T item)
        {
            if (_items.Length <= Count)
            {
                int newSize = _items.Length * 2;
                Array.Resize<T>(ref _items, newSize);
            }
            _items[Count] = item;
            Count++;
        }

        public void RemoveAt(int index)
        {
            if (index >= Count)
                throw new ArgumentException("Index zu groß");

            Array.Copy(_items, index + 1,
                       _items, index,
                       Count - (index + 1));
            _items[Count - 1] = default(T);
            Count--;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if ((_items[i] == null && item == null) ||
                    _items[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string content = "";
            for (int i = 0; i < Count; i++)
            {
                content += _items[i] + " -> ";
            }
            return content;
        }
    }
}
