namespace RemoveOddOccurance
{
    using System;
    using System.Collections.Generic;
    using NumbersOccurenceCount;

    public class RemoveOddOccurance
    {
        public static void Main(string[] args)
        {
            List<int> sequence = new List<int>()
            {
                4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2
            };

            Console.WriteLine(string.Join(", ", sequence));
            Console.WriteLine();
            Console.WriteLine("Removed odd occurances: ");

            var result = RemoveOddOccuredNumbers(sequence);
            Console.WriteLine(string.Join(", ", result));
        }

        public static List<int> RemoveOddOccuredNumbers(ICollection<int> sequence)
        {
            Dictionary<int, int> numbersCount = OccurancesCounter.GetCounts(sequence);
            List<int> result = new List<int>();

            foreach (var number in sequence)
            {
                if (numbersCount[number] % 2 == 0)
                {
                    result.Add(number);
                }
            }

            return result;
        }
    }
}
