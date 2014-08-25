namespace NumbersOccurenceCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumberOccurenceCounter
    {
        public static void Main(string[] args)
        {
            List<int> sequence = new List<int>()
            {
                3, 4, 4, 2, 3, 3, 4, 3, 2
            };

            Console.WriteLine(string.Join(", ", sequence));
            Console.WriteLine();

            var numbersCount = OccurancesCounter.GetCounts(sequence);
            PrintOutput(numbersCount);
        }

        private static void PrintOutput(Dictionary<int, int> numbersCount)
        {
            foreach (var count in numbersCount)
            {
                string outputLine = string.Format("{0} -> {1} times.", count.Key, count.Value);
                Console.WriteLine(outputLine);
            }
        }
    }
}
