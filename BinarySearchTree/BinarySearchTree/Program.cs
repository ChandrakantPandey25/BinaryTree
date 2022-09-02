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
                    CreateBinarySearchTree<int> binarytree = new CreateBinarySearchTree<int>();
                    binarytree.Insert(56);
                    binarytree.Insert(30);
                    binarytree.Insert(70);
                    binarytree.DisplayBST(binarytree.root);
                    break;
                case 2:
                    ShowBinarySearchTree<int> binaryTree = new ShowBinarySearchTree<int>();                    
                    int[] arr = { 56, 30, 70, 22, 60, 40, 95, 16, 63, 67, 4, 11, 65 };                    
                    for (int i = 0; i < arr.Length; i++)
                    {
                        binaryTree.Insert(arr[i]);
                    }
                    binaryTree.DisplayBST(binaryTree.root);
                    Console.WriteLine("\n Size of Binary Search Tree: " + binaryTree.Size(binaryTree.root));
                    break;
                case 3:
                    ShearchBinarySearchTree<int> binarysTree = new ShearchBinarySearchTree<int>();                    
                    int[] array = { 56, 30, 70, 22, 60, 40, 95, 16, 63, 67, 4, 11, 65 };                  
                    for (int i = 0; i < array.Length; i++)
                    {
                        binarysTree.Insert(array[i]);
                    }
                    binarysTree.DisplayBST(binarysTree.root);
                    Console.WriteLine("\n Size of Binary Search Tree: " + binarysTree.Size(binarysTree.root));                    
                    Console.WriteLine();
                    Console.WriteLine("Searching for Element 63 in the Binary Search Tree");
                    binarysTree.Search(63);
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }
        }
    }
}
