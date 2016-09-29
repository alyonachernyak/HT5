using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Collections
{
    class Read_Operation
    {
        List<int> list = new List<int>();
        LinkedList<int> linkedList = new LinkedList<int>();
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        Queue<int> queue = new Queue<int>();
        Stack<int> stack = new Stack<int>();
        SortedSet<int> sortedSet = new SortedSet<int>();
        SortedDictionary<int, int> sortedDictionary = new SortedDictionary<int, int>();

        public long ReadFromList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
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

            for (int i = 0; i < 10000000; i++)
            {
                linkedList.AddLast(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long ReadFromDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                dictionary.Add(i, i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long ReadFromQueue()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                queue.Peek();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long ReadFromStack()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                stack.Peek();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long ReadFromSortedSet()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                sortedSet.Add(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long ReadFromSortedDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                sortedDictionary.Add(i, i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }



        //public void Start()
        //{
        //    Console.WriteLine($"Read operation: ");
        //    Console.WriteLine($"List: {ReadFromList()}");
        //    Console.WriteLine($"LinkedList: {ReadFromLinkedList()}");
        //    Console.WriteLine($"Dictionary: {ReadFromDictionary()}");
        //    Console.WriteLine($"Queue: {ReadFromQueue()}");
        //    Console.WriteLine($"Stack: {ReadFromStack()}");
        //    Console.WriteLine($"SortedSet: {ReadFromSortedSet()}");
        //    Console.WriteLine($"SortedDictionary: {ReadFromSortedDictionary()}");
        //}
    }
}
