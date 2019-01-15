using System;

namespace KlausurAuD
{
    public class BinaryTree<TKey, TValue> where TKey : IComparable<TKey>
    {
        // Name:
        // Matrikelnr.:
        //
        // 3. Aufgabe

        private class Node
        {
            public Node(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }



        private void AddTo(Node parent, TKey key, TValue value)
        {
            if (key.CompareTo(parent.Key) <= 0)  // links einsortieren
            {
                if (parent.Left == null)
                    parent.Left = new Node(key, value);
                else
                    AddTo(parent.Left, key, value);
            }
            else                                // rechts einsortieren
            {
                if (parent.Right == null)
                    parent.Right = new Node(key, value);
                else
                    AddTo(parent.Right, key, value);
            }
        }

        public int Count { get; private set; }

        Node root;

        public void Add(TKey key, TValue value)
        {
            if (root == null)
                root = new Node(key, value);
            else
                AddTo(root, key, value);

            Count++;
        }

        public bool ContainsKey(TKey key)
        {
            Node parent = root;

            while (parent != null)
            {
                int compare = key.CompareTo(parent.Key);

                if (compare == 0)
                {
                    return true;
                }
                else if (compare > 0)
                {
                    parent = parent.Right;
                }
                else
                {
                    parent = parent.Left;
                }
            }
            return false;
        }

        public TValue this[TKey key]
        {
            get
            {
                Node parent = root;

                while (parent != null)
                {
                    int compare = key.CompareTo(parent.Key);

                    if (compare == 0)
                    {
                        return parent.Value;
                    }
                    else if (compare > 0)
                    {
                        parent = parent.Right;
                    }
                    else
                    {
                        parent = parent.Left;
                    }
                }
                throw new ArgumentException("Schlüssel nicht vorhanden");
            }
        }



        public override string ToString()
        {
            string s = "";
            int level = 0;

            Traverse(root, level, ref s);

            return s;
        }

        private void Traverse(Node node, int level, ref string s)
        {
            if (node == null)
                return;

            // PreOrder
            // Knoten
            s += "".PadLeft(level, ' ') + node.Key.ToString() + "\n";
            Traverse(node.Left, level + 2, ref s);
            Traverse(node.Right, level + 2, ref s);
        }
    }
}