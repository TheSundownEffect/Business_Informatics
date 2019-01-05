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
            throw new NotImplementedException();





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