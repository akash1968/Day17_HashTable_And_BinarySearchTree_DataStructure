// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearchTree.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_HashTable_And_BinarySearchTree_DataStructure
{
    // Defining a Generic Class Binary Search Tree
    class BinarySearchTree<T> where T : IComparable
    {
       // Defining a generic Node root
        public Node<T> root;
       // Default Constructor for the class BinarySearchTree
        public BinarySearchTree()
        {
            this.root = null;
        }
 //UC1- Insert the element in the specified node depending upon the value passed by user as data
        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                // Defining the current node as root
                Node<T> current = root;
               // Defining the parent node
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    // If Data is less than root data then passing it to left node
                    if (data.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    //If Data is Greater than root data then passing it to right node
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }
 // Displaying the Binary tree In the default in Order from left branch to node to right branch
        public void DisplayBST(Node<T> parent)
        {
            Console.WriteLine("Parent : {0}", parent.data);
            if (parent.Left != null)
            {
                Console.WriteLine("Left :" + parent.Left.data);
            }
            if (parent.Right != null)
            {
                Console.WriteLine("Right :" + parent.Right.data);
            }
            if (parent.Left != null)
            {
                DisplayBST(parent.Left);
            }
            if (parent.Right != null)
            {
                DisplayBST(parent.Right);
            }
        }
       // Method to Get the size of the Binary Search Tree
        public int Size(Node<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                // Adding the all the left node, all the right nodes and the root node 
                return (Size(node.Left) + 1 + Size(node.Right));
            }
        }
       // Method to search in the Binary Tree Set
        public void Search(T element)
        {
            // Declaring the current node as root
            Node<T> current = root;
            bool found = false;
            while (current != null)
            {
                // Checking if the element to be searched is root
                if (current.data.Equals(element))
                {
                    found = true;
                    break;
                }
                else
                {
                    // Checking if the element to be searched is present in the left side of Binary Tree
                    if (element.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                    }
                    // Checking if the element to be searched is present in the right side of Binary Tree
                    else
                    {
                        current = current.Right;
                    }
                }
            }
            if (found)
                Console.WriteLine("Element Found");
            else
                Console.WriteLine("Element Not Found");
        }
    }
}
