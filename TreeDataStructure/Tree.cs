using System;
using System.Collections.Generic;

namespace TreeDataStructure
{
    public class Tree
    {
        public Node Insert(Node root, int value)
        {
            if (root == null)
            {
                root = new Node();
                root.Value = value;
            }
            else
            {
                if (value <= root.Value)
                {
                    root.LeftNode = Insert(root.LeftNode, value);
                }
                else
                {
                    root.RightNode = Insert(root.RightNode, value);
                }
            }
            return root;
        }

        public void DFSPreOrderDisplay(Node root)
        {
            Console.WriteLine(root.Value);
            if (root.LeftNode != null)
            {
                DFSPreOrderDisplay(root.LeftNode);
            }
            if (root.RightNode != null)
            {
                DFSPreOrderDisplay(root.RightNode);
            }
        }

        public void DFSInOrderDisplay(Node root)
        {
            if (root.LeftNode != null)
            {
                DFSInOrderDisplay(root.LeftNode);
            }
            Console.WriteLine(root.Value);
            if (root.RightNode != null)
            {
                DFSInOrderDisplay(root.RightNode);
            }
        }

        public void DFSPostOrderDisplay(Node root)
        {
            if (root.LeftNode != null)
            {
                DFSPostOrderDisplay(root.LeftNode);
            }
            if (root.RightNode != null)
            {
                DFSPostOrderDisplay(root.RightNode);
            }
            Console.WriteLine(root.Value);
        }

        public void BFSDisplay(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node current_node = queue.Dequeue();
                Console.WriteLine(current_node.Value);

                if (current_node.LeftNode != null)
                {
                    queue.Enqueue(current_node.LeftNode);
                }
                if (current_node.RightNode != null)
                {
                    queue.Enqueue(current_node.RightNode);
                }
            }
        }

        public bool FindNode(Node root, int value)
        {
            if (value < root.Value && root.LeftNode != null)
            {
                return FindNode(root.LeftNode, value);
            }
            if (value > root.Value && root.RightNode != null)
            {
                return FindNode(root.RightNode, value);
            }
            return value == root.Value;
        }
    }
}
