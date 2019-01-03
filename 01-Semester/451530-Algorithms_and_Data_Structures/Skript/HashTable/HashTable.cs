/* * * * * * *
 * Title:   HashTable
 * Class:   HashTable.cs
 * Author:  Christian B.
 * Date:    02.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace HashTable
{
    public class HashTable<TKey, TValue>
    {
        List<KeyValuePair>[] items;

        internal class KeyValuePair
        {
            public KeyValuePair(TKey key, TValue value)
            {
                this.key = key;
                this.value = value;
            }
            public TKey key { get; set; }
            public TValue value { get; set; }
        }

        public int Count { get; private set; }

        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < items.Length; i++)
                {
                    int index = key.GetHashCode() % items.Length;
                    if (items[i] != null)
                    {
                        if (key.Equals(items[i][0].key))
                        {
                            return items[i][0].value;
                        }
                    }
                }
                throw new Exception("Wert nicht vorhanden");
            }
        }


        public HashTable(int size = 10)
        {
            items = new List<KeyValuePair>[size];
        }

        public void Add(TKey key, TValue value)
        {
            int index = key.GetHashCode() % items.Length;

            if (items[0] == null)
            {
                items[index] = new List<KeyValuePair>();
            }

            var pair = new KeyValuePair(key, value);

            items[index].Add(pair);
            Count++;
        }

        public bool Contains(TKey key)
        {
            int index = key.GetHashCode() % items.Length;

            var list = items[index];

            if (list == null)
                return false;

            foreach (var pair in list)
            {
                if (pair.key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Remove(TKey key)
        {
            if (key == null)
                throw new Exception("Empty!");

            int index = key.GetHashCode() % items.Length;

            var list = items[index];

            if (list == null)
                return false;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (key.Equals(items[i][0].key))
                    {
                        items[i][0].key = default(TKey);
                        items[i][0].value = default(TValue);
                        Count--;
                        return true;
                    }
                }
            }
            return false;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }
    }
}
