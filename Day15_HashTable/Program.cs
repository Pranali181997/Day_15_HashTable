using System;
using System.Linq;
namespace Day15_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");




            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter the program number which is to be executed \n 1.UC-1, \n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        MyHashTable<string, string> hashtable = new MyHashTable<string, string>(5);
                        hashtable.Add("0", "To");
                        hashtable.Add("1", "Be");
                        hashtable.Add("2", "Or");
                        hashtable.Add("3", "Not");
                        hashtable.Add("4", "To");
                        hashtable.Add("5", "Be");
                        
                        string myHashTable5 = hashtable.Get("5");
                        Console.WriteLine($"The value of 5th index is " + myHashTable5);
                        Console.ReadLine();
                        break;
                 
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}