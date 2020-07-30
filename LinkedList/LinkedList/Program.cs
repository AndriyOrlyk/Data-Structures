using LinkedList.Model;
using System;
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

            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);

            foreach(var item in circularList)
                Console.WriteLine(item);
            Console.WriteLine();

            circularList.Delete(3);

            foreach (var item in circularList)
                Console.WriteLine(item);

            Console.WriteLine();

            Console.WriteLine();

            var duplexList = new DuplexLinkedList<int>();
            duplexList.Add(10);
            duplexList.Add(20);
            duplexList.Add(30);
            duplexList.Add(40);
            duplexList.Add(50);
            duplexList.Add(60);
            duplexList.Add(70);

            foreach(var item in duplexList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            duplexList.Delete(40);

            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            

            foreach (var item in duplexList.Reverse())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


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
