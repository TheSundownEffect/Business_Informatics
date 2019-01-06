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

namespace Company
{
    public enum TraverseModeEnum { PreOrder, PostOrder, InOrder, ReverseInOrder }

    public class BinaryTree<T> where T : IComparable<T>
    {
        class Node
        {
            public T Key { get; set; }
            //public TValue Value { get; set; }
            public Node nextLeft { get; set; }
            public Node nextRight { get; set; }
        }

        Node root;

        public TraverseModeEnum TraverseMode { get; set; }

        public BinaryTree()
        {
            Count = 0;
            root = null;
            TraverseMode = TraverseModeEnum.InOrder;
        }


        public int Count { get; private set; }


        public void Add(T key)
        {
            if (root == null)
            {
                var node = new Node
                {
                    Key = key
                   
                };

                root = node;
            }
            else
            {
                AddTo(root, key);
            }
            Count++;
        }

        private void AddTo(Node node, T key)
        {
            if (key.CompareTo(node.Key) < 0)
            {
                if (node.nextLeft == null)
                    node.nextLeft = new Node() { Key = key };
                else
                    AddTo(node.nextLeft, key);
            }
            else
            {
                if (node.nextRight == null)
                    node.nextRight = new Node() { Key = key };
                else
                    AddTo(node.nextRight, key);
            }
        }

        public bool Contains(T key)
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


        public T Search(T item)
        {
            Node node = root;

            while (node != null)
            {
                int c = node.Key.CompareTo(item);

                if (c == 0)
                    return node.Key;

                if (c > 0)
                    node = node.nextLeft;
                else
                    node = node.nextRight;
            }
            throw new ArgumentException("Eintrag nicht gefunden!");
        }


        public override string ToString()
        {
            string s = "";

            if (root == null)
                throw new ArgumentException("BinaryTree is empty");

            traverse(root, ref s);

            return s;
        }

        void Traverse(TraverseModeEnum modus, Node node, ref string s)
        {
            switch (modus)
            {
                case TraverseModeEnum.PreOrder:


                    break;
                case TraverseModeEnum.PostOrder:
                    break;
                case TraverseModeEnum.InOrder:
                    break;
                case TraverseModeEnum.ReverseInOrder:
                    break;
                default:
                    break;
            }
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
