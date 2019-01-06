using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS2017II
{
    public class HashMap<TKey, TValue>
    {
        List<Pair>[] items;

        public HashMap(int size = 10)
        {
            items = new List<Pair>[size];
        }

        private class Pair
        {
            public Pair(TKey key, TValue value)
            {
                this.key = key;
                this.value = value;
            }
            public TKey key;
            public TValue value;
        }

        public int Count { get; private set; }

        public IEnumerable<TKey> Keys
        {
            get
            {
                foreach (var list in items)
                {
                    if (list != null)
                    {
                        foreach (Pair pair in list)
                        {
                            yield return pair.key;
                        }
                    }
                }
            }
        }

        public void Add(TKey key, TValue value)
        {
            int index = key.GetHashCode() % items.Length;
            var list = items[index];

            if (list == null)
                list = items[index] = new List<Pair>();

            var pair = new Pair(key, value);
            list.Add(pair);

            Count++;
        }

        public bool Contains(TKey key)
        {
            int index = key.GetHashCode() % items.Length;
            if (items[index] == null)
                return false;

            var list = items[index];
            foreach (Pair pair in list)
            {
                if (pair.key.Equals(key))
                    return true;
            }
            return false;
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = key.GetHashCode() % items.Length;
                if (items[index] == null)
                    throw new ArgumentException("Schlüssel gibts nicht");

                var list = items[index];
                foreach (Pair pair in list)
                {
                    if (pair.key.Equals(key))
                        return pair.value;
                }
                throw new ArgumentException("Schlüssel gibts nicht");
            }
        }
    }
}
