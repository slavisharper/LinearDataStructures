namespace SequenseWithList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageAndSum
    {
        public static void Main(string[] args)
        {
            var input = ReadInput();
            int sum = CalculateSum(input);
            int avrg = CalculateAverage(input);

            Console.WriteLine("The sum is " + sum + ".");
            Console.WriteLine("The average is " + avrg + ".");
        }

        private static List<int> ReadInput()
        {
            List<int> input = new List<int>();
            string line = Console.ReadLine();

            while (line.Length > 0)
            {
                try
                {
                    int currentNumber = int.Parse(line);
                    input.Add(currentNumber);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
                finally
                {
                    line = Console.ReadLine();
                }
            }

            return input;
        }

        private static int CalculateSum(List<int> list)
        {
            int sum = 0;

            foreach (var item in list)
            {
                sum += item;
            }

            return sum;
        }

        private static int CalculateAverage(List<int> list)
        {
            if (list.Count == 0)
            {
                return 0;
            }

            int avrg = CalculateSum(list);
            int average = avrg / list.Count;
            return avrg;
        }
    }
}
