using System;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDay1Result();
            GetDay2Result();
        }




        private static void GetDay1Result()
        {
            Console.WriteLine("Day 1 - puzzle 1: " + Day1.Day1_SonarSweep.GetSolutionPuzzleOne());
            Console.WriteLine("Day 1 - puzzle 2: " + Day1.Day1_SonarSweep.GetSolutionPuzzleTwo());
        }

        private static void GetDay2Result()
        {
            Console.WriteLine("Day 2 - puzzle 1: " + Day2.Day2_Dive.GetSolutionPuzzleOne());
            Console.WriteLine("Day 2 - puzzle 2: " + Day2.Day2_Dive.GetSolutionPuzzleTwo());

        }
    }
}
