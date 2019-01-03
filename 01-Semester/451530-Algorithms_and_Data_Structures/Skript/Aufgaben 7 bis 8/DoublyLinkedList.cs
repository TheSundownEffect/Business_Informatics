/* * * * * * *
 * Title:   Aufgaben_7_bis_8
 * Class:   DoublyLinkedList.cs
 * Author:  Christian B.
 * Date:    02.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace Aufgaben_7_bis_8
{
    class DoublyLinkedList<T> : IEnumerable
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


        /* Lösung: Aufgabe 7
         * 
         * class Node
         * 
         * public void Add(T data)
         * 
         * public bool Remove(T data)
         * 
         */
        #region Lösung: Aufgabe 7
        class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }
        }

        public void Add(T data)
        {
            var item = new Node();
            item.Data = data;
            item.Next = null;
            item.Prev = null;

            if (_first == null) // setze erstes Element
            {
                _first = item;
                _last = item;
            }
            else // setze letztes Element
            {
                _last.Next = item;
                item.Prev = _last;
                _last = item;
            }
            Count++;
        }

        public bool Remove(T data)
        {
            if (_first.Data.Equals(data)) // Erstes Element löschen
            {
                _first = _first.Next;
                _first.Prev = null;
            }
            else
            {
                Node node = Find(data);
                if (node == null)
                    return false;

                Node prevNode = node.Prev;
                // Mitte oder Ende
                if (prevNode != null)
                {
                    prevNode.Next = node.Next;
                    if (prevNode.Next != null)
                    {
                        prevNode.Next.Prev = node.Prev;
                    }
                if (node == _last)
                    _last = prevNode;
                } else // ersten entfernen
                {
                    _first = node.Next;

                    if (_first == null)
                    {
                        _last = null;
                    } else
                    {
                        _first.Prev = null;
                    }
                }

            }
            Count--;
            return true;
        }

        #endregion

        /* Lösung: Aufgabe 8
         * 
         * public bool InsertAfter(T previousItem, T item) 
         * 
         */
        #region Lösung: Aufgabe 8
        public bool InsertAfter(T previousItem, T item)
        {
            Node previousNode = Find(previousItem);
            if (previousNode == null)
                return false;

            Node newNode = new Node() { Data = item };
            newNode.Next = previousNode.Next;
            newNode.Prev = previousNode;

            previousNode.Next = newNode;

            if (newNode.Next != null)
                newNode.Next.Prev = newNode;
            else
                _last = newNode;

            Count++;

            return true;
        }

        #endregion

        public void Clear()
        {
            _first = _last = null;
            Count = 0;
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

            content += '\n';

            aktuellerKnoten = _last;

            while (aktuellerKnoten != null)
            {
                content += aktuellerKnoten.Data + " -> ";
                aktuellerKnoten = aktuellerKnoten.Prev;
            }

            return content;
        }
    }
}
