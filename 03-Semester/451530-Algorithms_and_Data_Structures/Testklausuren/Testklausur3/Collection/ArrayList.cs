﻿namespace My.Collections
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ArrayList<T> : IEnumerable<T>
    {
        protected T[] items;

        public int Count { get; private set; }
        
        public ArrayList(int length = 0)
        {
            items = new T[length == 0 ? 4 : length];
        }

        public void Add(T item)
        {
            grow();

            items[Count] = item;

            Count++;
        }

        public void AddRange(T[] items)
        {
            foreach (T item in items)
                Add(item);
        }

        public int IndexOf(T item) 
        {
            return Array.IndexOf(items, item);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();

            Array.Copy(items, index + 1, items, index, Count - (index + 1));

            Count--;
            items[Count] = default(T);
        }

        public bool Remove(T item)
        {
            for(int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            items = new T[4];
            Count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index >= Count)
                    throw new IndexOutOfRangeException();

                return items[index];
            }
            set
            {
                if (index >= Count)
                    throw new IndexOutOfRangeException();

                items[index] = value;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for(int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        public override string ToString()
        {
            string s = "";

            for(int i = 0; i < Count; i++)
            { 
                s += items[i].ToString() + " -> ";
            }
            s += "Count: " + Count.ToString();

            return s;
        }

        private void grow()
        {
            // Überprüfen, ob noch Platz
            if (items.Length >= Count + 1)
                return;

            // Array-Kapazität verdoppeln
            int newLength = items.Length * 2;

            Array.Resize(ref items, newLength);            
        }
    }
}