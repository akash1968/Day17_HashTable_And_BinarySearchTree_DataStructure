// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyMapNode.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Day17_HashTable_And_BinarySearchTree_DataStructure
{
    public class MyMapNode<K, V>
    {
        // defining member variables
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
      // creating constructor of the class
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
      // Class For Key Value Pair with data type structure
        public struct KeyValue<k, v>
        {
            // defining members elements with the properties
            public k Key { get; set; }
            public v Value { get; set; }
        }
         // Hash Code Method to Find the Array Position with key as the parameter
        // Gets a unique array items[] position for entered key.
        protected int GetArrayPosition(K key)
        {
            /// Returns a unique position to each different key
            int position = key.GetHashCode() % size;
            // Math function to find the absolute position at which the particular key value pair is situated
            return Math.Abs(position);
        }
      // Creating a GetLinkedList Method with return type as KeyValue Pair
        // Gets the linked list present at the entered position in the items[] array
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            // Retreving key value pair at the index of position
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                /// Creates new linked list and update items[] array with the same
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
      // Gets the value at the specified key.
      // Generic Method to find the key value pair at the particular position
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
           // Iterating using the foreach loop to get the value if the keys are equal
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }
            return default(V);
        }
       // Generic Method to Adds the specified key,value pair at the end of the linked list present at the position corresponding to the key.       
        public void Add(K key, V value)
        {
            /// Gets the position to the key
            int position = GetArrayPosition(key);
            /// Gets the linked list present at the position
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> kvp = new KeyValue<K, V>() { Key = key, Value = value };
            /// Adds the key-value pair at the end of the linked list
            linkedList.AddLast(kvp);
            Console.WriteLine(linkedList.Last.Value.Key + " " + linkedList.Last.Value.Value);
        }
        // Generic Method to Remove a particular item from the Hash Table
        public void Remove(K key)
        {
            // Getting the position of the item at the particular key 
            int position = GetArrayPosition(key);
            // Getting the key Value Pair at the given position
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            // Iterating using the for each loop to find the key value pair in the linked list
            foreach(KeyValue<K,V> item in linkedList)
            {
               // if both the key matches then returning true               
                if(item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if(itemFound)
            {
                // Removing the item from the hash table 
                linkedList.Remove(foundItem);
            }
        }
        // UC 1 : Prints the frequency of the specified value in the hashtable.
        public void GetFrequencyOf(V value)
        {
            int count = 0;
            // Iterating using the foreach loop to get the key value of each item
            foreach (var linkedList in items)
            {
                // checking if key is not null 
                if (linkedList != null)
                {
                    // iterating using the foreach loop to get the value of the item in linked list
                    foreach (var v in linkedList)
                    {
                        // if the entered value matches the key value then incresing the frequency count
                        if (v.Value.Equals(value))
                            count++;
                    }
                }
            }
            Console.WriteLine($"Frequency of '{value}'= {count}");
        }
    }
}
