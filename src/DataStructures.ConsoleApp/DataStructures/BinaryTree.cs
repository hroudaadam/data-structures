namespace DataStructures.ConsoleApp.DataStructures.BinaryTree;

public static class BinaryTreeExample
{
    public static void Run()
    {
        BinaryTreeNode root = new(1,
            new BinaryTreeNode(2,
                new BinaryTreeNode(4),
                new BinaryTreeNode(5)),
            new BinaryTreeNode(3));

        BinaryTree.Inorder(root);
        Console.WriteLine();
        BinaryTree.Preorder(root);
        Console.WriteLine();
        BinaryTree.Postorder(root);
        Console.WriteLine();
    }
}

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