namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestSequence
    {
        public static void Main(string[] args)
        {
            List<int> sequence = new List<int>()
            {
                3, 5, 4, 4, 4, 4, 5, 5, 8, 8, 8, 8, 8
            };

            Console.WriteLine(string.Join(", ", sequence));
            Console.WriteLine("The longest sequence is: ");

            var longestSequence = FindLongestSequenceOfEqual(sequence);
            Console.WriteLine(string.Join(", ", longestSequence));
        }

        public static List<int> FindLongestSequenceOfEqual(List<int> numbers)
        {
            int maxCount = 0;
            int maxMetNumber = 0;
            int currentCount = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                int currNumber = numbers[i];
                if (currNumber == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxMetNumber = numbers[i - 1];
                    }

                    currentCount = 1;
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                maxMetNumber = numbers[numbers.Count - 1];
            }

            var result = GenerateIntList(maxMetNumber, maxCount);
            return result;
        }

        private static List<int> GenerateIntList(int maxMetNumber, int maxCount)
        {
            var result = new List<int>(maxCount);
            for (int i = 0; i < maxCount; i++)
            {
                result.Add(maxMetNumber);
            }

            return result;
        }
    }
}
