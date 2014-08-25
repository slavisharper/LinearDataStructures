namespace CalculateSequence
{
    using System;
    using System.Collections.Generic;

    public class SequenceCalculator
    {
        private const int NumbersToShow = 50;

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = CalculateSequence(n);
            Console.WriteLine(string.Join(", ", result));
        }

        private static List<int> CalculateSequence(int n)
        {
            List<int> result = new List<int>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            while (result.Count <= NumbersToShow)
            {
                int current = queue.Dequeue();
                result.Add(current);

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }

            if (result.Count > NumbersToShow)
            {
                result.RemoveRange(NumbersToShow, result.Count - NumbersToShow);
            }

            return result;
        }
    }
}
