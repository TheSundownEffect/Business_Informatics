using System;
using System.Collections;

namespace ConsoleApp10
{
    public class LinkedList : IEnumerable
    {
        public void Clear()
        {
            last = first = null;
            Count = 0;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];
            }

        }

        //class LinkedListEnumerator : IEnumerator
        //{
        //    Node _first;
        //    Node _current;
        //    public LinkedListEnumerator(Node first)
        //    {
        //        _first = _current = first;
        //    }

        //    public object Current
        //    {
        //        get
        //        {
        //            return _current.Data;
        //        }
        //    }

        //    bool _firstNext = false;
        //    public bool MoveNext()
        //    {
        //        if (_firstNext == false)
        //        {
        //            _firstNext = true;
        //            return true;
        //        }
        //        if (_current.Next == null)
        //            return false;
        //        _current = _current.Next;
        //        return true;
        //    }

        //    public void Reset()
        //    {
        //        _current = _first; 
        //    }
        //}

        public int Count { get; private set; }

        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }
        }

        public object this[int index]
        {
            get
            {
                Node node = FindByIndex(index);
                return node.Data;
            }
            set
            {
                Node node = FindByIndex(index);
                node.Data = value;
            }
        }

        private Node first;
        private Node last;

        public void Add(object data)
        {
            var item = new Node();
            item.Data = data;

            if(first == null)   // keine Elemente vorhanden
            {
                first = item;
                last = item;
            }
            else                // mehr als 1 Wert
            {
                // finde letztes Element
                last.Next = item;
                last = item;
            }
            Count++;
        }

        public bool Contains(object data)
        {
            var n = GetPreviousNode(last);

            Node node = first;
            while(node != null)
            {
                if(node.Data.Equals(data) == true)
                {
                    return true;
                }
                node = node.Next;
            }
            return false;
        }

        public bool Remove(object data)
        {
            if(first.Data.Equals(data)) // 1. Element löschen
            {
                first = first.Next;
            }
            else // letzte und aus der Mitte
            {
                Node node = Find(data);
                if (node == null)
                    return false;
                Node prev = GetPreviousNode(node);
                prev.Next = node.Next;
                node.Next = null;
                if (node == last)
                    last = prev;
            }
            Count--;
            return true;
        }

        private Node FindByIndex(int index)
        {
            if (index > Count - 1)
                throw new IndexOutOfRangeException("Index außerhalb des Bereichs");

            int vergleich = 0;
            Node aktuellerKnoten = first;

            while (aktuellerKnoten != null)
            {
                if (vergleich == index)
                    return aktuellerKnoten;
                vergleich++;
                aktuellerKnoten = aktuellerKnoten.Next;
            }
            return null;
        }

        private Node Find(object data)
        {
            Node aktuellerKnoten = first;

            while (aktuellerKnoten != null)
            {
                if(aktuellerKnoten.Data.Equals(data) == true)
                {
                    return aktuellerKnoten;
                }
                aktuellerKnoten = aktuellerKnoten.Next;
            }
            return null;
        }

        public override string ToString()
        {
            string content = "";
            Node aktuellerKnoten = first;

            while(aktuellerKnoten != null)
            {
                content += aktuellerKnoten.Data + " -> ";
                aktuellerKnoten = aktuellerKnoten.Next;
            }

            return content;
        }

        private Node GetPreviousNode(Node node)
        {
            Node aktuellerKnoten = first;
            while (aktuellerKnoten != null)
            {
                if (aktuellerKnoten.Next == node)
                    return aktuellerKnoten;
                aktuellerKnoten = aktuellerKnoten.Next;
            }
            return null;
        }


    }
}
