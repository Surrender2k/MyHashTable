﻿using System;

namespace MyHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of hash table");
            int size = int.Parse(Console.ReadLine());

            var hashTable = new HashTable(size);
            int variant;
            int item;
            Console.WriteLine("1-add, 2-delete, 3-find, 4-show, 5-quit, default-continue");
            while (true)
            {
                variant=int.Parse(Console.ReadLine());
                switch (variant)
                {
                    case 1:
                        item= int.Parse(Console.ReadLine());
                        hashTable.Add(item);
                        break;
                    case 2: 
                        item = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        continue;
                        
                }
            }

        }
    }
}
