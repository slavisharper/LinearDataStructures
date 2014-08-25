namespace SequenceWithStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseNumbers
    {
        public static void Main(string[] args)
        {
            var input = ReadInput();
            string output = string.Join(", ", input);
            Console.WriteLine(output);
        }

        private static Stack<int> ReadInput()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> input = new Stack<int>(n);

            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                input.Push(currNum);
            }

            return input;
        }
    }
}
