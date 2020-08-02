using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            
            var rnd = new Random();
            var startItems = new List<int>();

            for(var i = 0; i < 10; i++)
            {
                startItems.Add(rnd.Next(-1000, 1000));
            }
            timer.Start();
            var heap = new Heap(startItems);
            timer.Stop();
            Console.WriteLine("Initial thousand initialization of 1000 elements " + timer.Elapsed);


            timer.Restart();
            for (var i = 0; i < 10; i++)
            {
                startItems.Add(rnd.Next(-1000, 1000));
            }
            timer.Stop(); 
            Console.WriteLine("Add second thousand elements " + timer.Elapsed);

            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Output of 2000 elements " + timer.Elapsed);






        }
    }
}
