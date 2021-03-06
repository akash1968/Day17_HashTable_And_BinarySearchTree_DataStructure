﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
namespace Day17_HashTable_And_BinarySearchTree_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
 //UC_3- Searching for a particular element in the Binary Tree Set
            Console.WriteLine("Welcome to Binary Search Tree");
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
           // Inserting all the elements in the array
            int[] arr = { 56, 30, 70, 22, 60, 40, 95, 16, 63, 67, 4, 11, 65 };
           // iterating using for loop to add each element to the binary tree at a time
            for (int i = 0; i < arr.Length; i++)
            {
                bst.Insert(arr[i]);
            }
           // Displaying the elements of the Binary Search Tree
            bst.DisplayBST(bst.root);
            Console.WriteLine("\n\nSize of Binary Search Tree: " + bst.Size(bst.root));
            // Searching the element 63 in Binary Search Tree
            Console.WriteLine();
            Console.WriteLine("Searching for Element 63 in the Binary Search Tree");
            bst.Search(63);
        }
    }
}
