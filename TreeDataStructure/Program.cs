using System;

namespace TreeDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            Tree bst = new Tree();
            Node root = null;

            Console.WriteLine("Printing Values in Array...");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Inserting Nodes in Tree");
            for (int i = 0; i < arr.Length; i++)
            {
                root = bst.Insert(root, arr[i]);
            }

            Console.WriteLine("* DFS *");

            Console.WriteLine("Pre Order Display:");
            bst.DFSPreOrderDisplay(root);

            Console.WriteLine("In Order Display:");
            bst.DFSInOrderDisplay(root);

            Console.WriteLine("Post Order Display:");
            bst.DFSPostOrderDisplay(root);

            Console.WriteLine("* BFS *");
            bst.BFSDisplay(root);

            Console.WriteLine("* Search Value in Nodes*");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bst.FindNode(root, value));

        }
    }
}
