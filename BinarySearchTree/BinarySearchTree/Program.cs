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
                    CreateBinarySearchTree<int> binarytree = new CreateBinarySearchTree<int>();
                    binarytree.Insert(56);
                    binarytree.Insert(30);
                    binarytree.Insert(70);
                    binarytree.DisplayBST(binarytree.root);
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }
        }
    }
}
