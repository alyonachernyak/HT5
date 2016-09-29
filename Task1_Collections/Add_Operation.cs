using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Collections
{
    public class Add_Operation
    {
        static List<int> list { get; set; } = new List<int>();
        static LinkedList<int> linkedList = new LinkedList<int>();
        static Dictionary<int, int> dictionary = new Dictionary<int, int>();
        static Queue<int> queue = new Queue<int>();
        static Stack<int> stack = new Stack<int>();
        static SortedSet<int> sortedSet = new SortedSet<int>();
        static SortedDictionary<int, int> sortedDictionary = new SortedDictionary<int, int>();

        public long AddToList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for(int i=0; i < 100000; i++)
            {
                list.Add(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long AddToLinkedList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                linkedList.AddLast(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long AddToDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                dictionary.Add(i, i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long AddToQueue()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                queue.Enqueue(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long AddToStack()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                stack.Push(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long AddToSortedSet()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                sortedSet.Add(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long AddToSortedDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                sortedDictionary.Add(i, i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }




        public long ReadFromList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                int a = list[i];
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long ReadFromLinkedList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                int a = linkedList.ElementAt(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long ReadFromDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                var keyValuePair = dictionary.ElementAt(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long ReadFromQueue()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                int a = queue.Peek();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long ReadFromStack()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                int a = stack.Peek();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long ReadFromSortedSet()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                int a = sortedSet.ElementAt(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long ReadFromSortedDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                var keyValuePair = sortedDictionary.ElementAt(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }







        public static long FindInList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                //list[i];
            }
            var find = list.Find(x => x < 50000);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInLinkedList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                linkedList.Find(i);
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var containsKey = dictionary.ContainsKey(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInQueue()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //for (int i = 0; i < 100000; i++)
            //{
            //    queue.
            //}
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInStack()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //for (int i = 0; i < 100000; i++)
            //{
            //    stack.
            //}
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInSortedSet()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var getViewBetween = sortedSet.GetViewBetween(i - 1, i + 1);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInSortedDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                sortedDictionary.TryGetValue(i, out i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }







        public long RemoveFromList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                list.Remove(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long RemoveFromLinkedList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                linkedList.Remove(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long RemoveFromDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                dictionary.Remove(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long RemoveFromQueue()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                queue.Dequeue();

            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }


        public long RemoveFromStack()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                stack.Pop();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long RemoveFromSortedSet()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                sortedSet.Remove(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long RemoveFromSortedDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                sortedDictionary.Remove(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public void Start()
        {
            Console.WriteLine($"Add operation: ");
            Console.WriteLine($"List: {AddToList()}");
            Console.WriteLine($"LinkedList: {AddToLinkedList()}");
            Console.WriteLine($"Dictionary: {AddToDictionary()}");
            Console.WriteLine($"Queue: {AddToQueue()}");
            Console.WriteLine($"Stack: {AddToStack()}");
            Console.WriteLine($"SortedSet: {AddToSortedSet()}");
            Console.WriteLine($"SortedDictionary: {AddToSortedDictionary()}");
            Console.WriteLine("");


            Console.WriteLine($"Read operation: ");
            Console.WriteLine($"List: {ReadFromList()}");
            Console.WriteLine($"LinkedList: {ReadFromLinkedList()}");
            Console.WriteLine($"Dictionary: {ReadFromDictionary()}");
            Console.WriteLine($"Queue: {ReadFromQueue()}");
            Console.WriteLine($"Stack: {ReadFromStack()}");
            Console.WriteLine($"SortedSet: {ReadFromSortedSet()}");
            Console.WriteLine($"SortedDictionary: {ReadFromSortedDictionary()}");
            Console.WriteLine("");

            Console.WriteLine($"Find operation: ");
            Console.WriteLine($"List: {FindInList()}");
            Console.WriteLine($"LinkedList: {FindInLinkedList()}");
            Console.WriteLine($"Dictionary: {FindInDictionary()}");
            Console.WriteLine($"Queue: {FindInQueue()}");
            Console.WriteLine($"Stack: {FindInStack()}");
            Console.WriteLine($"SortedSet: {FindInSortedSet()}");
            Console.WriteLine($"SortedDictionary: {FindInSortedDictionary()}");
            Console.WriteLine("");


            Console.WriteLine($"Remove operation: ");
            Console.WriteLine($"List: {RemoveFromList()}");
            Console.WriteLine($"LinkedList: {RemoveFromLinkedList()}");
            Console.WriteLine($"Dictionary: {RemoveFromDictionary()}");
            Console.WriteLine($"Queue: {RemoveFromQueue()}");
            Console.WriteLine($"Stack: {RemoveFromStack()}");
            Console.WriteLine($"SortedSet: {RemoveFromSortedSet()}");
            Console.WriteLine($"SortedDictionary: {RemoveFromSortedDictionary()}");
        }
    } 
}
