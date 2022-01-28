using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode LeftChild { get; set; }
        public BinaryTreeNode RightChild { get; set; }

        public BinaryTreeNode(int value, BinaryTreeNode leftChild = null, BinaryTreeNode rightChild = null)
        {
            Value = value;
            LeftChild = leftChild;
            RightChild = rightChild;
        }
    }

    public static class BinaryTree
    {
        public static void Inorder(BinaryTreeNode root)
        {
            if (root.LeftChild != null)
            {
                Inorder(root.LeftChild);
            }

            Console.Write(root.Value + " ");

            if (root.RightChild != null)
            {
                Inorder(root.RightChild);
            }
        }

        public static void Preorder(BinaryTreeNode root)
        {
            Console.Write(root.Value + " ");

            if (root.LeftChild != null)
            {
                Preorder(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                Preorder(root.RightChild);
            }
        }

        public static void Postorder(BinaryTreeNode root)
        {

            if (root.LeftChild != null)
            {
                Postorder(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                Postorder(root.RightChild);
            }

            Console.Write(root.Value + " ");
        }
    }
}