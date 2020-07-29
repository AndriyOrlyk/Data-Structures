﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
            {
                Console.Write(item + " \t");
            }
            Console.WriteLine();

            list.Delete(3);
            list.Delete(1);
            list.Delete(7);

            foreach (var item in list)
            {
                Console.Write(item + " \t");
            }
            Console.WriteLine();
            list.AppendHead(9);

            foreach (var item in list)
            {
                Console.Write(item + " \t");
            }
            Console.WriteLine();

            list.InsertAfter(4, 8);

            foreach (var item in list)
            {
                Console.Write(item + " \t");
            }
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}