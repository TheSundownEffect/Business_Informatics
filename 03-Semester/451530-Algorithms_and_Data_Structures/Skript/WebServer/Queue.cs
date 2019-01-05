using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace WebServer
{
    public class Queue<T> : ICollection
    {
        private T[] items;

        public int Count { get; private set; }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public T Dequeue()
        {
            if (Count <= 0)
                throw new IndexOutOfRangeException("Keine Elemente");
            T aktuellerWert = items[0];
            Array.Copy(items, 1, items, 0, Count - 1);
            items[Count - 1] = default(T);
            Count--;
            return aktuellerWert;
        }

        public void Enqueue(T data)
        {
            if (Count == items.Length)
                Array.Resize(ref items, Count * 2);
            items[Count] = data;
            Count++;
        }

        public T Peek()
        {
            if (Count <= 0)
                throw new IndexOutOfRangeException("Keine Elemente");
            return items[0];
        }
    }
}