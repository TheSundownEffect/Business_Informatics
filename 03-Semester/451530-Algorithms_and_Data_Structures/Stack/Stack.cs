using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStack
{
    class Stack<T> : ICollection
    {
        T[] items = new T[4];

        public int Count { get; private set; }

        public void Push(T data)
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
            return items[Count - 1];
        }
        public T Pop()
        {
            if (Count <= 0)
                throw new IndexOutOfRangeException("Keine Elemente");
            T aktuellerWert = items[Count - 1];
            items[Count - 1] = default(T);
            Count--;
            return aktuellerWert;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
