using System;
using System.Collections;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            #region LinkedList
            //LinkedList ll = new LinkedList();
            //ll.AddFirst(1);
            //ll.AddBefore(5, ll.First);
            //ll.AddBefore(7, ll.First);
            //ll.AddBefore(5, ll.First);
            //ll.RemoveFirst();
            //ll.Remove(ll.First);

            //Console.WriteLine(ll);
            //Console.WriteLine(ll.Count);
            #endregion

            #region Queue
            //Queue q = new Queue();
            //q.Enqueue(5);
            //q.Enqueue(13);
            //q.Enqueue(1);
            //q.Enqueue(3);
            //Console.WriteLine(q);

            //Console.WriteLine(q.Dequeque());
            //Console.WriteLine(q.Peek());
            #endregion

            #region Stack
            //Stack s = new();
            //s.Push(1);
            //s.Push(5);
            //s.Push(13);
            //s.Push(18);
            //Console.WriteLine(s.Peek());
            //Console.WriteLine(s.Pop());

            //Console.WriteLine(s);
            #endregion

            #region DynamicArray
            //DynamicArray a = new();
            //a.Add(8);
            //a.Add(8);
            //a.Add(8);
            //a[0] = 1;
            //a[1] = 2;
            //a[2] = 3;

            //Console.WriteLine(a);

            //a.RemoveAt(0);
            //a.RemoveAt(0);
            //a.RemoveAt(0);

            //Console.WriteLine(a);
            #endregion

            #region BinaryTree

            //BinaryTreeNode root = new(1,
            //    new BinaryTreeNode(2,
            //        new BinaryTreeNode(4),
            //        new BinaryTreeNode(5)),
            //    new BinaryTreeNode(3));

            //BinaryTree.Inorder(root);
            //Console.WriteLine();
            //BinaryTree.Preorder(root);
            //Console.WriteLine();
            //BinaryTree.Postorder(root);
            //Console.WriteLine();

            #endregion

            Console.ReadKey();
        }
    }
}
