using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie<int>();
            trie.Add("Hello", 50);
            trie.Add("World", 100);
            trie.Add("Prize", 200);
            trie.Add("Herald", 150);
            trie.Add("Gift", 210);
            trie.Add("Project", 220);
            trie.Add("Ordinary", 230);
            trie.Add("Right", 240);
            trie.Add("Year", 250);
            trie.Add("Hero", 260);
            trie.Add("Beauty", 260);
            trie.Add("pigeon", 270);
            trie.Add("Eye", 280);
            trie.Add("Procrastination", 1000);

            trie.Remove("Right");
            trie.Remove("World");

            Search(trie,"Hello");
            Search(trie, "World");
            Search(trie, "Cloud");
            Search(trie, "Herald");
            Search(trie, "Ordinary");
            Search(trie, "Procrastination");

            Console.ReadKey();

        }

        private static void Search(Trie<int> trie, string word)
        {
            if (trie.TrySearch(word, out int value))
            {
                Console.WriteLine(word + " " + value);
            }
            else
            {
                Console.WriteLine("Not Found " + word);
            }
        }
    }
}
