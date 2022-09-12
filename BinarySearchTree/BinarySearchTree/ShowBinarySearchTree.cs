using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{

    class ShowBinarySearchTree<T> where T : IComparable
    {
        public Node<T> root;

        public ShowBinarySearchTree()
        {
            root = null;
        }
        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (root == null)
            {
                root = newNode;
                return;
            }
            else
            {
                Node<T> current = root, parent = null;

                while (true)
                {
                    parent = current;

                    if (data.CompareTo(current.data) < 0)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }

        }


        public void Display(Node<T> node)
        {

            Console.WriteLine("Parent : {0}", root.data);
            if (root.left != null)
            {
                Console.WriteLine("Left :" + root.left.data);
            }
            if (root.right != null)
            {
                Console.WriteLine("Right :" + root.right.data);
            }
            if (root.left != null)
            {
                Display(root.left);
            }
            if (root.right != null)
            {
                Display(root.right);
            }


        }
       

    }
}
