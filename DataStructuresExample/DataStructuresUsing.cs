namespace DataStructuresExample
{
    using System;
    using DataStructures;

    public class DataStructuresUsing
    {
        public static void Main(string[] args)
        {
            LinkedListExample();
            StackExample();
            LinkedQueueExample();
        }

        private static void LinkedQueueExample()
        {
            var queue = new LinkedQueue<int>();

            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            // 0
            Console.WriteLine(queue.Dequeue());

            // 9
            Console.WriteLine(queue.Count);

            // 123456789
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

        private static void StackExample()
        {
            ResizableStack<int> stack = new ResizableStack<int>(5);
            Console.WriteLine("Count: {0}, Capacity: {1}", stack.Count, stack.Capacity);
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine(string.Join(", ", stack.ToArray()));
            Console.WriteLine();

            int lastElemet = stack.Pop();
            Console.WriteLine("Last element {0} is deleted.", lastElemet);
            Console.WriteLine(string.Join(", ", stack.ToArray()));
            Console.WriteLine();

            int lastElemetPeeked = stack.Peek();
            Console.WriteLine("Last element {0} is only peeked.", lastElemetPeeked);
            Console.WriteLine(string.Join(", ", stack.ToArray()));
            Console.WriteLine();

            bool isTwoContained = stack.Contains(2);
            bool isTenContained = stack.Contains(10);
            Console.WriteLine("Contains 2: {0}, contains 10: {1}", isTwoContained, isTenContained);
            Console.WriteLine();

            Console.WriteLine("Not trimmed - Count: {0}, Capacity: {1}", stack.Count, stack.Capacity);
            stack.TrimExcess();
            Console.WriteLine("Trimmed - Count: {0}, Capacity: {1}", stack.Count, stack.Capacity);
            Console.WriteLine();

            var newStack = new ResizableStack<string>(new string[] { "gos", "sad" });
            Console.WriteLine(newStack.Capacity);
            Console.WriteLine(newStack.Count);
        }

        private static void LinkedListExample()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(423);
            list.AddFirst(21);
            Console.WriteLine(string.Join(", ", list.ToList()));
            list.AddFirst(423);
            list.AddLast(22);
            list.AddLast(23453);
            Console.WriteLine(string.Join(", ", list.ToList()));
            list.RemoveFirst();
            Console.WriteLine(string.Join(", ", list.ToList()));
            list.RemoveLast();
            Console.WriteLine(string.Join(", ", list.ToList()));
            Console.WriteLine(list.Count);
            Console.WriteLine( );
        }
    }
}
