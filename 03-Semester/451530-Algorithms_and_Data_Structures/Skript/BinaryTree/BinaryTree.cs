/* * * * * * *
 * Title:   BinaryTree
 * Class:   BinaryTree.cs
 * Author:  Christian B.
 * Date:    02.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace BinaryTree
{
    public class BinaryTree<TKey, TValue> where TKey : IComparable<TKey>
    {
        class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node nextLeft { get; set; }
            public Node nextRight { get; set; }
        }

        Node root;

        public int Count { get; private set; }

        public TValue Min
        {
            get
            {
                if (root == null)
                    throw new ArgumentException("BinaryTree is empty");
                Node runNode = root;
                while (runNode.nextLeft != null)
                    runNode = runNode.nextLeft;

                return (runNode.Value);
            }
        }

        public TValue Max
        {
            get
            {
                if (root == null)
                    throw new ArgumentException("BinaryTree is empty");
                Node runNode = root;
                while (runNode.nextRight != null)
                    runNode = runNode.nextRight;

                return (runNode.Value);
            }
        }

        #region Indexer
        public TValue this[TKey key]
        {
            get
            {
                Node runNode = root;
                while (runNode != null)
                {
                    int c = key.CompareTo(runNode.Key);

                    if (c == 0)
                    {
                        return runNode.Value;
                    }
                    if (c < 0)
                    {
                        runNode = runNode.nextLeft;
                    }
                    else
                    {
                        runNode = runNode.nextLeft;
                    }
                }
                throw new ArgumentException("Wrong Index");
            }
        }
        #endregion

        public BinaryTree()
        {
            Count = 0;
            root = null;
        }


        public void Add(TKey key, TValue value)
        {
            if (root == null)
            {
                var node = new Node
                {
                    Key = key,
                    Value = value
                };

                root = node;
            }
            else
            {
                AddTo(root, key, value);
            }
            Count++;
        }

        private void AddTo(Node node, TKey key, TValue value)
        {
            if (key.CompareTo(node.Key) < 0)
            {
                if (node.nextLeft == null)
                    node.nextLeft = new Node() { Key = key, Value = value };
                else
                    AddTo(node.nextLeft, key, value);
            }
            else
            {
                if (node.nextRight == null)
                    node.nextRight = new Node() { Key = key, Value = value };
                else
                    AddTo(node.nextRight, key, value);
            }
        }

        public bool Contains(TKey key)
        {
            Node runNode = root;
            while (runNode != null)
            {
                int c = key.CompareTo(runNode.Key);

                if (c == 0)
                {
                    return true;
                }
                if (c < 0)
                {
                    runNode = runNode.nextLeft;
                }
                else
                {
                    runNode = runNode.nextRight;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string s = "";

            if (root == null)
                throw new ArgumentException("BinaryTree is empty");

            traverse(root, ref s);

            return s;
        }

        void traverse(Node node, ref string s)
        {
            if (node.nextLeft != null)
                traverse(node.nextLeft, ref s);
            s += " " + node.Key + " ";
            if (node.nextRight != null)
                traverse(node.nextRight, ref s);
        }

    }
}
