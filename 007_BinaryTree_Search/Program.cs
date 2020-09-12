﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_BinaryTree_Search
{
    class Program
    {
        static void Main (string[] args)
        {
            BinaryTree<int> instance = new BinaryTree<int>();

            instance.Add(8);    //                        8
            instance.Add(5);    //                      /   \
            instance.Add(12);   //                     5    12 
            instance.Add(3);    //                    / \   / \  
            instance.Add(7);    //                   3   7 10 15
            instance.Add(10);   //
            instance.Add(15);   //

            Console.WriteLine(instance.Contains(7));
            Console.WriteLine(instance.Contains(100));

            Console.ReadKey();

        }
    }
}
