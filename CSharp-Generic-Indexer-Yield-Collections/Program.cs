using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Generic_Indexer_Yield_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic Collections
            // Stack
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n=======Generic Collections=======\n");

            Console.WriteLine("\n=======Stack=======\n");

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("peek: "+myStack.Peek());
            Console.WriteLine("pop: "+myStack.Pop());
            Console.WriteLine("peek: " + myStack.Peek());
            Console.WriteLine("pop: " + myStack.Pop());

            //Queue
            Console.WriteLine("\n=======Queue=======\n");

            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("peek: "+myQueue.Peek());
            Console.WriteLine("dequeue: "+myQueue.Dequeue());
            Console.WriteLine("peek: "+myQueue.Peek());
            Console.WriteLine("dequeue: " + myQueue.Dequeue());

            //SortedList
            Console.WriteLine("\n=======SortedList=======\n");

            SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Johannesburg", "South Africa"}
                                    };
            cities.Add("Sumgait", "Azerbaijan");
            cities.Remove("Mumbai");
            cities.ContainsKey("Baku");
            cities.RemoveAt(0);
            foreach (var c in cities) { Console.WriteLine(c); }
            Console.WriteLine("------------------------");
            foreach (var key in cities.Keys) { Console.WriteLine("key: "+key); }
            Console.WriteLine("------------------------");
            foreach (var value in cities.Values) { Console.WriteLine("value: "+value); }

            //Dictionary
            Console.WriteLine("\n=======Dictionary=======\n");
            
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(1, "One");
            dic.Add(2, "Two");
            dic.Add(3, "Three");
            dic.Add(4, "Four");
            dic.Add(5, "Five");
            dic.Remove(1);
            if (dic.ContainsKey(2))
            {
                dic.Remove(2);
            }
            foreach (var num in dic) { Console.WriteLine(num); }
            Console.WriteLine("------------------------");
            
            foreach (var key in dic.Keys) { Console.WriteLine("key: "+key); }
            Console.WriteLine("------------------------");

            foreach(var value in dic.Values) { Console.WriteLine("value: "+value); }

            //HashSet
            Console.WriteLine("\n=======HashSet=======\n");

            HashSet<string> myhash1 = new HashSet<string>();
            //Console.WriteLine("my hash-1:\n");
            myhash1.Add("Iphone");
            myhash1.Add("Xiaomi");
            myhash1.Add("Samsung");
            myhash1.Add("Nokia");
            myhash1.Add("Apple");

            myhash1.Remove("Nokia");
            Console.WriteLine("my hash-1:\n");
            foreach(var h in myhash1) { Console.WriteLine(h); }
            Console.WriteLine("myHash count:"+myhash1.Count);

            HashSet<string> myhash2 = new HashSet<string>();
            myhash2.Add("Apple");
            myhash2.Add("Microsoft");
            myhash2.Add("Tesla");
            Console.WriteLine("------------------------");
            Console.WriteLine("my hash-2:\n");

            //Console.WriteLine("my hash-1 union with my hash-2:\n");
            //myhash1.UnionWith(myhash2);
            foreach (var h in myhash1) { Console.WriteLine(h); }

            Console.WriteLine("------------------------");
            Console.WriteLine("my hash-1 intersect with my hash-2:\n");
            myhash1.IntersectWith(myhash2);
            foreach (var h in myhash1) { Console.WriteLine(h); }

            Console.WriteLine("------------------------");
            Console.WriteLine("my hash-1 except with my hash-2:\n");
            myhash1.ExceptWith(myhash2);
            foreach (var h in myhash1) { Console.WriteLine(h); }

            //List
            Console.WriteLine("\n=======List=======\n");

            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            Console.WriteLine("------------------------");
            Console.WriteLine("prime numbers:\n");

            foreach (int h in primeNumbers) { Console.WriteLine(h); }

            List<int> evenNumbers = new List<int>();
            evenNumbers.Add(2);
            evenNumbers.Add(4);
            evenNumbers.Add(6);
            evenNumbers.Add(8);
            evenNumbers.Add(10);
            Console.WriteLine("------------------------");
            Console.WriteLine("even numbers:\n");

            foreach (var h in evenNumbers) { Console.WriteLine(h); }

            evenNumbers.AddRange(primeNumbers);
            Console.WriteLine("------------------------");
            Console.WriteLine("even numbers added to prime numbers:\n");

            foreach (var h in evenNumbers) { Console.WriteLine(h); }

            Console.WriteLine("------------------------");
            Console.WriteLine("foreach using:\n");

            evenNumbers.ForEach(num => Console.WriteLine(num));

            Console.WriteLine("------------------------");
            Console.WriteLine("Remove(value) & RemoveAt(index):\n");

            evenNumbers.Remove(2);
            evenNumbers.RemoveAt(0);
            foreach(var h in evenNumbers) { Console.WriteLine(h); }

            // Non-Generic Collections
            // ArrayList
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n=======Non-Generic Collections=======\n");

            Console.WriteLine("\n=======ArrayList=======\n");

            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            // istenilen type-da element elave etmek mumkundur.

            //arlist1.AddRange(arlist2); //adding arraylist in arraylist 
            arlist1.AddRange(arr); //adding array in arraylist 
            arlist1.AddRange(myQ); //adding Queue in arraylist

            var firstElement = arlist1[0]; 
            var secondElement = arlist1[1];
            
            foreach(var item in arlist1) { Console.WriteLine(item); }

            Console.WriteLine("------------------------");
            Console.WriteLine("After Insert values:\n");

            arlist1.Insert(0, "salaaaam");
            arlist1.InsertRange(1, arlist2);
            foreach(var item in arlist1) { Console.WriteLine(item); }

            Console.WriteLine("------------------------");
            Console.WriteLine("After Remove values:\n");

            arlist1.Remove(myQ);
            arlist1.RemoveAt(0);
            arlist1.RemoveRange(2,4);
            foreach(var item in arlist1) { Console.WriteLine(item); }

            //SortedList
            Console.WriteLine("\n=======SortedList=======\n");

            SortedList sortedList = new SortedList();
            sortedList.Add(1,"bir");
            sortedList.Add(2, "iki");
            sortedList.Add(3, "uc");
            
            foreach (var item in sortedList.Keys) { Console.WriteLine("key: "+item); }
            Console.WriteLine("------------------------");
            foreach (var item in sortedList.Values) { Console.WriteLine("value: "+item); }

            sortedList.Clear();
            Console.WriteLine("After clear list: ");
            foreach (var item in sortedList.Values) { Console.WriteLine("value: " + item); }

            //Stack
            Console.WriteLine("\n=======Stack=======\n");

            Stack stack = new Stack();
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);
            stack.Push(15);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("peek: " + stack.Peek());
            Console.WriteLine("pop: " + stack.Pop());
            Console.WriteLine("peek: " + stack.Peek());
            Console.WriteLine("pop: " + stack.Pop());

            //Queue
            Console.WriteLine("\n=======Queue=======\n");

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("peek: " + queue.Peek());
            Console.WriteLine("dequeue: " + queue.Dequeue());
            Console.WriteLine("peek: " + queue.Peek());
            Console.WriteLine("dequeue: " + queue.Dequeue());

            //HashTable
            Console.WriteLine("\n=======Hashtable=======\n");

            var cities1 = new Hashtable(){
                                            {"UK", "London, Manchester, Birmingham"},
                                            {"USA", "Chicago, New York, Washington"},
                                            {"India", "Mumbai, New Delhi, Pune"}
                                         };

            foreach (var city in cities1.Keys) { Console.WriteLine("key: " + city); }
            foreach (var city in cities1.Values) { Console.WriteLine("value: " + city); }

            Console.WriteLine("------------------------");
            Console.WriteLine("Check with ContainsKey:");

            if (!cities1.ContainsKey("France"))
            {
                cities1["France"] = "Paris";
            }
            foreach (var city in cities1.Keys) { Console.WriteLine("key: "+city); }
            foreach (var city in cities1.Values) { Console.WriteLine("value: "+city); }

            Console.WriteLine("------------------------");
            Console.WriteLine("Check with ContainsKey & Remove:");
            if (cities1.ContainsKey("France"))
            { 
                cities1.Remove("France");
            }
            foreach (var city in cities1.Keys) { Console.WriteLine("key: " + city); }
            foreach (var city in cities1.Values) { Console.WriteLine("value: " + city); }

            Console.WriteLine("------------------------");
            Console.WriteLine("Clear :");

            cities1.Clear();
            foreach (var city in cities1.Keys) { Console.WriteLine("key: " + city); }
            foreach (var city in cities1.Values) { Console.WriteLine("value: " + city); }

        }
    }
}
