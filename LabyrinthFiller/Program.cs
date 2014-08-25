namespace LabyrinthFiller
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static string[,] labyrinth;

        public static void Main(string[] args)
        {
            int startRow = int.Parse(Console.ReadLine());
            int startCol = int.Parse(Console.ReadLine());
            labyrinth = ParseInput();
            FillLabyrinth(startRow, startCol, 0);
            PrintLabyrinth(labyrinth);
        }

        private static void FillLabyrinth(int row, int col, int number) 
        {
            if (labyrinth[row, col] != "*")
            {
                labyrinth[row, col] = number.ToString();
            }

            ExploreDirections(row, col, number);
        }

        private static void ExploreDirections(int row, int col, int number)
        {
            if (labyrinth.GetLength(0) > row + 1 && labyrinth[row + 1, col] == "0")
            {
                FillLabyrinth(row + 1, col, number + 1);
            }

            if (row - 1 >= 0 && labyrinth[row - 1, col] == "0")
            {
                FillLabyrinth(row - 1, col, number + 1);
            }

            if (col - 1 >= 0 && labyrinth[row, col - 1] == "0")
            {
                FillLabyrinth(row, col - 1, number + 1);
            }

            if (labyrinth.GetLength(1) > col + 1 && labyrinth[row, col + 1] == "0")
            {
                FillLabyrinth(row, col + 1, number + 1);
            }
        }

        private static void PrintLabyrinth(string[,] labyrinth)
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == "0")
                    {
                        labyrinth[i, j] = "u";
                    }

                    Console.Write(string.Format("{0, 3}", labyrinth[i, j]));
                }

                Console.WriteLine();
            }
        }

        private static string[,] ParseInput()
        {
            List<string[]> inputLines = new List<string[]>();
            string line = Console.ReadLine();

            while (line.Length > 0)
            {
                inputLines.Add(line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries));
                line = Console.ReadLine();
            }

            string[,] labirynth = new string[inputLines.Count, inputLines[0].Length];

            for (int i = 0; i < inputLines.Count; i++)
            {
                for (int j = 0; j < inputLines[0].Length; j++)
                {
                    labirynth[i, j] = inputLines[i][j];
                }
            }
            return labirynth;
        }
    }
}
