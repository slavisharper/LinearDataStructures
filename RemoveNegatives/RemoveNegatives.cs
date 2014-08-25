namespace RemoveNegatives
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegatives
    {
        public static void Main(string[] args)
        {
            List<int> sequence = new List<int>()
            {
                3, -5, 4, 4, 4, -4, 5, 5, 8, 8, -8, 8, -8
            };

            Console.WriteLine(string.Join(", ", sequence));
            Console.WriteLine();
            Console.WriteLine("The refined sequence: ");

            var refinedSequence = RemoveNegativeNumbers(sequence);
            Console.WriteLine(string.Join(", ", refinedSequence));
        }

        private static List<int> RemoveNegativeNumbers(List<int> sequence)
        {
            var refined = new List<int>();

            foreach (var number in sequence)
            {
                if (number < 0)
                {
                    continue;
                }

                refined.Add(number);
            }

            return refined;
        }
    }
}
