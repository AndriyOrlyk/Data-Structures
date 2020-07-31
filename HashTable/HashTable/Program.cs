using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var superHashTable = new SuperHashTable<Person>(100);
            var person = new Person() { Name = "Andriy", Age = 20, Gender = 0 };
            superHashTable.Add(new Person() { Name = "Yaroslav", Age = 20, Gender = 0}) ;
            superHashTable.Add(new Person() { Name = "Kate", Age = 17, Gender = 1 });
            superHashTable.Add(new Person() { Name = "Vasya", Age = 25, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Yuriy", Age = 28, Gender = 0 });
            superHashTable.Add(person);

            Console.WriteLine(superHashTable.Search(new Person() { Name = "Andriy", Age = 20, Gender = 0 }));
            Console.WriteLine(superHashTable.Search(person));

            Console.WriteLine();

            var person1 = new Person() { Name = "Andriy", Age = 20, Gender = 0 , Id=1};
            var person2 = new Person() { Name = "Kate", Age = 17, Gender = 1, Id = 2 };
            var person3 = new Person() { Name = "Vasya", Age = 25, Gender = 0, Id = 3 };
            var hashTable = new HashTable<int, Person>(10);
            hashTable.Add(person1.Id, person);
            hashTable.Add(person2.Id, person);
            hashTable.Add(person3.Id, person);
            Console.WriteLine(hashTable.Search(person1.Id, person1));
            Console.WriteLine(hashTable.Search(person2.Id, person3));


            //var hashTable = new HashTable<int, string>(100);
            //hashTable.Add(5, "Hello");
            //hashTable.Add(18, "World");
            //hashTable.Add(777, "Hey");
            //hashTable.Add(7, "Developer");


            //Console.WriteLine(hashTable.Search(6, "Andriy"));
            //Console.WriteLine(hashTable.Search(18, "World"));

            Console.WriteLine();

            var badHashTable = new BadHashTable<int>(100);
            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(777);
            badHashTable.Add(7);

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));

            Console.ReadLine();
        }
    }
}
