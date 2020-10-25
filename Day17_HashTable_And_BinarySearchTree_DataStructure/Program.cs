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
            // UC_3- Ability to Remove particular words in large paragraph phrase
            // Creating an object of MyMapNode Class
            // size of the hash table is 20
            MyMapNode<string, string> hash = new MyMapNode<string, string>(20);
           // Storing the sentence in the variable para
            string para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            // spliting the words of the phrase and storing each word in the Array String
            string[] paraWords = para.Split(' ');
           // Getting the length of the Array String
            int pLength = paraWords.Length;
            // Itreating along each word and adding it to hash set
            for (int i = 0; i < pLength; i++)
            {
                hash.Add(Convert.ToString(i), paraWords[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Removing the word 'avoidable' from the hash table ");
            Console.WriteLine("Frequency of 'avoidable' before removal is :" + hash.GetFrequency("avoidable"));
            hash.RemoveValue("avoidable");
            Console.WriteLine("Frequency of 'avoidable' after removal is :" + hash.GetFrequency("avoidable"));
            Console.ReadLine();
        }
    }
}
