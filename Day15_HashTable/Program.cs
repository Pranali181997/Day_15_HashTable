using System;
using System.Linq;
namespace Day15_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //MyHashTable<string,string> myHashTable = new MyHashTable<string, string>(5);
            //myHashTable.Add("0","To");
            //myHashTable.Add("1", "be");
            //myHashTable.Add("2", "or");
            //myHashTable.Add("3", "Not");
            //myHashTable.Add("4", "To");
            //myHashTable.Add("5", "Be");

            //string myHashTable5 = myHashTable.Get("5");
            //Console.WriteLine($"The value of 5th index is " + myHashTable5);


            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.Exit");
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
                        MyHashTable<string, int> hashtable1 = new MyHashTable<string, int>(5);
                        string input = "Paranoids are are not paranoid because they are paranoid but because they \n    keep putting themselves deliberately into paranoid avoidable situations\n";
                        Console.WriteLine($"Statement is:- {input}");
                        try
                        {
                            string[] inputArray = input.Split();
                            foreach (string word in inputArray)
                            {
                                if (hashtable1.Get(word) == 0)
                                {
                                    hashtable1.Add(word, 1);
                                }
                                else
                                {
                                    int value = hashtable1.Get(word) + 1;
                                    hashtable1.Set(word, value);
                                }
                            }
                            string[] newInputArray = inputArray.Distinct().ToArray();
                            foreach (var word in newInputArray)
                            {
                                Console.WriteLine("Frequency of Word occurrence :- \"" + word + "\" is :- " + hashtable1.Get(word));
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        MyHashTable<string, int> hashtable11 = new MyHashTable<string, int>(5);
                        string input11 = "Paranoids are are not paranoid because they are paranoid but because they \n    keep putting themselves deliberately into paranoid avoidable situations\n";
                        Console.WriteLine($"Statement is:- {input11}");
                        try
                        {
                            string[] inputArray = input11.Split();
                            foreach (string word in inputArray)
                            {
                                if (hashtable11.Get(word) == 0)
                                {
                                    hashtable11.Add(word, 1);
                                }
                                else
                                {
                                    int value = hashtable11.Get(word) + 1;
                                    hashtable11.Set(word, value);
                                }
                            }
                            string[] newInputArray = inputArray.Distinct().ToArray();
                            foreach (var word in newInputArray)
                            {
                                Console.WriteLine("Frequency of Word occurrence :- \"" + word + "\" is :- " + hashtable11.Get(word));
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
                        string input1 = "Paranoids are are not paranoid because they are paranoid but because they \n               keep putting themselves deliberately into paranoid avoidable situations\n";
                        Console.WriteLine($"Statement is:- {input11}");
                        hashtable11.Display();
                        try
                        {

                            string[] inputArray = input11.Split();

                            foreach (string word in inputArray)
                            {
                                if (hashtable11.Get(word) == 0)
                                {
                                    hashtable11.Add(word, 1);
                                }
                                else
                                {
                                    int value = hashtable11.Get(word) + 1;
                                    hashtable11.Set(word, value);
                                }
                            }
                            string[] newInputArray = inputArray.Distinct().ToArray();
                            foreach (var word in newInputArray)
                            {
                                Console.WriteLine("Frequency of Word ccurrence :- \"" + word + "\" is :- " + hashtable11.Get(word));
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        hashtable11.Remove("avoidable");

                        Console.ReadLine();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}