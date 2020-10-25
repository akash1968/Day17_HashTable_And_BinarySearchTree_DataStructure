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
            // Creating an object of MyMapNode Class
            // size of the hash table is 5
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            Console.WriteLine("Adding KeyValue pair");
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            Console.WriteLine("Getting the value of index 5: " + hash.Get("5"));
            Console.WriteLine("Getting the value of index 2: " + hash.Get("2"));
           // UC1 - Ability to find frequency of words
            hash.GetFrequencyOf("be");
            Console.ReadLine();
        }
    }
}
