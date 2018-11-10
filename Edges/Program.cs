using System;

public class Node
{
    public Node left;
    public Node right;
    public int data;

    public Node(int data)
    {
        this.data = data;
        left = null;
        right = null;
    }
}

class Solution
{
    public static int height(Node root)
    {
        if (root.left == null && root.right == null)
        {
            return 0;
        }
        return height(root, 1);
    }

    public static int height(Node root, int sum)
    {
        if (root.left != null)
        {
            height(root.left, sum);
            sum++;
        }
        if (root.right != null)
        {
            height(root.right, sum);
            sum++;
        }
        return sum;
    }

    public static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }

    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        int t = scan.nextInt();
        Node root = null;
        while (t-- > 0)
        {
            int data = scan.nextInt();
            root = insert(root, data);
        }
        scan.close();
        int h = height(root);
        Console.WriteLine(h);
    }
}