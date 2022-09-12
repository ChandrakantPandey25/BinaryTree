using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Binary Search Tree!");
            Console.WriteLine("Enter 1 to create binary search tree");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    BinarySearchTree<int> binarytree = new BinarySearchTree<int>();
                    binarytree.insert(56);
                    binarytree.insert(30);
                    binarytree.insert(70);
                    binarytree.inorderTraversal(binarytree.root);
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }
        }
    }
}
