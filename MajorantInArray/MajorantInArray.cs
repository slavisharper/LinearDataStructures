namespace MajorantInArray
{
    using System;
    using System.Collections.Generic;
    using NumbersOccurenceCount;

    public class MajorantInArray
    {
        public static void Main(string[] args)
        {
            int[] sequence = 
            {
                2, 2, 3, 3, 2, 3, 4, 3, 3
            };

            Console.WriteLine(string.Join(", ", sequence));
            Console.WriteLine();

            try
            {
                Console.WriteLine("The majorant number is: " + FindMajorantNumber(sequence));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int FindMajorantNumber(ICollection<int> numbers)
        {
            int majorant = 0;
            int minCount = numbers.Count / 2 + 1;
            bool isMajorantFound = false;
            var numbersCount = OccurancesCounter.GetCounts(numbers);

            foreach (var numberCount in numbersCount)
            {
                if (numberCount.Value >= minCount)
                {
                    isMajorantFound = true;
                    majorant = numberCount.Key;
                    break;
                }
            }

            if (isMajorantFound)
            {
                return majorant;
            }
            else
            {
                throw new ArgumentException("No majorant element found!");
            }
        }
    }
}
