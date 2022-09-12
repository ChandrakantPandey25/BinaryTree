using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Binary Search Tree!");
            Console.WriteLine("Enter 1 to create binary search tree");
            Console.WriteLine("Enter 2 to show binary search tree");
            Console.WriteLine("Enter 3 to shearch in binary search tree");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    BinarySearchTree<int> binarytree = new BinarySearchTree<int>();
                    binarytree.insert(56);
                    binarytree.insert(30);
                    binarytree.insert(70);
                    binarytree.Display(binarytree.root);
                    break;
                case 2:
                    ShowBinarySearchTree<int> binarySearch = new ShowBinarySearchTree<int>();

                    binarySearch.Insert(30);
                    binarySearch.Insert(70);
                    binarySearch.Insert(22);
                    binarySearch.Insert(40);
                    binarySearch.Insert(60);
                    binarySearch.Insert(95);
                    binarySearch.Insert(11);
                    binarySearch.Insert(65);
                    binarySearch.Insert(3);
                    binarySearch.Insert(16);
                    binarySearch.Insert(63);
                    binarySearch.Insert(67);
                    binarySearch.Display(binarySearch.root);
                    break;
                case 3:
                    ShearchBinarySearchTree<int> binarysearch = new ShearchBinarySearchTree<int>();

                    binarysearch.Insert(30);
                    binarysearch.Insert(70);
                    binarysearch.Insert(22);
                    binarysearch.Insert(40);
                    binarysearch.Insert(60);
                    binarysearch.Insert(95);
                    binarysearch.Insert(11);
                    binarysearch.Insert(65);
                    binarysearch.Insert(3);
                    binarysearch.Insert(16);
                    binarysearch.Insert(63);
                    binarysearch.Insert(67);                    
                    Console.WriteLine("Searching 63 in the Binary Search Tree");
                    binarysearch.SearchNode(binarysearch.root,63);
                    if (ShearchBinarySearchTree<int>.search)
                        Console.WriteLine("Element is present in the binary tree");
                    else
                        Console.WriteLine("Element is not present in the binary tree");
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }
        }
    }
}
