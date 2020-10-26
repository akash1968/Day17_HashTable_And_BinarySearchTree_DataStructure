// --------------------------------------------------------------------------------------------------------------------
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
 //UC1- Insert the element in the specified node depending upon the value passed by user as data
            Console.WriteLine("Welcome to Binary Search Tree");
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.DisplayBST(bst.root);
        }
    }
}
