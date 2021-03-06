using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree_UC_2
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node()
        {

        }
        public Node(int data)
        {
            this.Data = data;

        }
    }
    public class BinaryTree
    {
        private Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(int data)
        {

            if (root == null)
            {
                root = new Node(data);
                return;
            }

            InsertRec(root, new Node(data));
        }
        private void InsertRec(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }
        private void DisplayTree(Node root)
        {
            if (root == null) return;

            DisplayTree(root.Left);
            System.Console.Write(root.Data + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(root);
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node();

            tree.Insert(56);
            tree.Insert(30);
            tree.Insert(70);
            tree.Insert(22);
            tree.Insert(40);
            tree.Insert(60);
            tree.Insert(95);
            tree.Insert(11);
            tree.Insert(65);
            tree.Insert(3);
            tree.Insert(16);
            tree.Insert(63);
            tree.Insert(67);

            tree.DisplayTree();

            int search = 63;

            if(search / 63 == 1)
            {
                Console.WriteLine("\nThe Value 63 is Inserted");
            }
            else
            {
                Console.WriteLine("\nThe Value 63 is Not Inserted ");
            }
        }
    }
}

