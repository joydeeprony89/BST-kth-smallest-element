using System;
using System.Collections.Generic;

namespace BST_kth_smallest_element
{
    class Program
    {
        public class Node
        {
            public Node left { get; set; }
            public Node right{ get; set; }
            public int val { get; set; }

            public Node(int val = 0)
            {
                left = right = null;
                this.val = val;
            }
        }
        static void Main(string[] args)
        {
            Node root = new Node(2);
            root.left = new Node(1);
            root.left.left = new Node(0);
            root.right = new Node(4);
            root.right.left = new Node(3);
            root.right.right = new Node(5);
            Console.WriteLine(KthSamllestElement(root, 5));
        }

        static int KthSamllestElement(Node root, int k)
        {
            Stack<Node> s = new Stack<Node>();
            while (root != null || s.Count > 0)
            {
                while (root != null)
                {
                    s.Push(root);
                    root = root.left;
                }
                var node = s.Pop();
                k--;
                if (k == 0) return node.val;
                root = node.right;
            }
            return -1;
        }
    }
}
