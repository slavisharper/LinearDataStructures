namespace SortList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortList
    {
        public static void Main(string[] args)
        {
            var input = ReadInput();
            input.Sort();
            string output = string.Join(", ", input);
            Console.WriteLine(output);
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
    }
}
