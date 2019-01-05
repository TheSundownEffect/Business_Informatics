namespace My.Collections
{
    using System;
    using System.Collections.Generic;

    public class UniqueArrayList<T>
    {
        protected T[] items;

        public int Count { get; private set; }

        public UniqueArrayList(int length = 0)
        {
            items = new T[length == 0 ? 4 : length];
        }

        //----------------------------------------------------
        // 2. Aufgabe
        // Name:
        // Matrikelnr.: 
 








        //----------------------------------------------------

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