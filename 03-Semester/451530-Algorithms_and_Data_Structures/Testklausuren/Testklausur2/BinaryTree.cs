using System;

namespace Testklausur2
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        private sealed class node<TNode> where TNode : IComparable<TNode>
        {
            public TNode Item { get; set; }
            public node<TNode> Left { get; set; }
            public node<TNode> Right { get; set; }

            public int CompareTo(TNode other)
            {
                return Item.CompareTo(other);
            }
        }

        private node<T> root;

        public int Count { get; private set; }

        public void Add(T item)
        {
            // 7. Aufgabe
            if(root == null)
            {
                var node = new node<T>
                {
                    Item = item
                };

                root = node;
            }
            else
            {
                var node = root;
                while (item.CompareTo(node.Item) < 0 || item.CompareTo(node.Item) > 0)
                {        
                    if (item.CompareTo(node.Item) <= 0)
                    {
                        if (node.Left == null)
                            node.Left = new node<T>() { Item = item };
                        else
                            node = node.Left;
                    } else
                    {
                        if (node.Right == null)
                            node.Right = new node<T>() { Item = item };
                        else
                            node = node.Right;
                    }
                }
            }
            Count++;
        }

        public override string ToString()
        {
            string s = "";
            traverse(root, 0, ref s);
            return s;
        }

        private void traverse(node<T> node, int level, ref string s)
        {
            if (node == null)
                return;

            s += "".PadLeft(level, ' ') + node.Item.ToString() + "\n";

            traverse(node.Left, level + 2, ref s);
            traverse(node.Right, level + 2, ref s);
        }
    }
}