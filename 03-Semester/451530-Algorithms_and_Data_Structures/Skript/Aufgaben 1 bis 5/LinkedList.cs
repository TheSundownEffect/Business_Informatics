/* * * * * * *
 * Title:   Aufgaben 1 bis 7
 * Class:   LinkedList.cs
 * Author:  Bräunlich, Christian
 * Date:    05.01.2019
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

namespace Aufgaben_1_bis_7
{
    #region Lösung: Aufgabe 6
    // class LinkedList<T>

    #endregion

    class LinkedList<T> : IEnumerable
    {
        #region [ Properties ]
        public int Count { get; private set; }
        private Node _first;
        private Node _last;

        #endregion

        #region [ Indexer ]
        public T this[int index]
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

        #endregion

        class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        #region Lösung: Aufgabe 2
        public void Add(T data)
        {
            var item = new Node();
            item.Data = data;

            if (_first == null) // setze erstes Element
            {
                _first = item;
                _last = item;
            }
            else // setze letztes Element
            {
                _last.Next = item;
                _last = item;
            }
            Count++;
        }
        #endregion

        public bool Remove(T data)
        {
            #region Lösung: Aufgabe 1
            if (_first.Data.Equals(data)) // Erstes Element löschen
                _first = _first.Next;
            #endregion

            else
            {
                Node node = Find(data);
                if (node == null)
                    return false;

                Node prev = GetPreviousNode(node);
                prev.Next = node.Next;
                node.Next = null;

                if (node == _last)
                    _last = prev;
            }
            Count--;
            return true;
        }

        public bool Contains(T data)
        {
            var tempNode = GetPreviousNode(_last);

            Node node = _first;
            while (node != null)
            {
                if (node.Data.Equals(data) == true)
                {
                    return true;
                }
                node = node.Next;
            }
            return false;
        }

        private Node GetPreviousNode(Node node)
        {
            Node aktuellerKnoten = _first;
            while (aktuellerKnoten != null)
            {
                if (aktuellerKnoten.Next == node)
                    return aktuellerKnoten;
                aktuellerKnoten = aktuellerKnoten.Next;
            }
            return null;
        }

        private Node Find(T data)
        {
            Node aktuellerKnoten = _first;

            while (aktuellerKnoten != null)
            {
                if (aktuellerKnoten.Data.Equals(data) == true)
                    return aktuellerKnoten;

                aktuellerKnoten = aktuellerKnoten.Next;
            }
            return null;
        }

        private Node FindByIndex(int index)
        {
            if (index > Count - 1)
                throw new IndexOutOfRangeException("Index außerhalb des Wertebereiches!");

            int vergleich = 0;
            Node aktuellerKnoten = _first;

            while (aktuellerKnoten != null)
            {
                if (vergleich == index)
                    return aktuellerKnoten;
                vergleich++;
                aktuellerKnoten = aktuellerKnoten.Next;
            }
            return null;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }

        public override string ToString()
        {
            string content = "";
            Node aktuellerKnoten = _first;

            while (aktuellerKnoten != null)
            {
                content += aktuellerKnoten.Data + " -> ";
                aktuellerKnoten = aktuellerKnoten.Next;
            }

            return content;
        }


        #region Lösung: Aufgabe 5
        public void Clear()
        {
            if (_first != null)
            {
                _first = _last = null;
                Count = 0;
            }
        }

        #endregion
    }
}