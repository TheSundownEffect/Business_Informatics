using System;
using System.Collections.Generic;

namespace KlausurAuD
{
    public class Stack<T> : List<T> where T : IComparable<T>
    {
        // Name: 
        // Matrikelnr.: 
        //
        // 4. Aufgabe        

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Push(T item)
        {
            Add(item);
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("No items on stack.");

            return this[Count - 1];
        }

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("No items on stack.");

            T item = this[Count - 1];
            this.RemoveAt(Count - 1);

            return item;
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < Count; i++)
            {
                s += this[i].ToString() + " -> ";
            }
            s += "Count: " + Count.ToString();

            return s;
        }
    }
}