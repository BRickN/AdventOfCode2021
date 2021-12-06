using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AdventOfCode2021.Day2
{

    class Day2_Dive
    {

        private static string measurementsFilePath = "C:/Users/rickn/Documents/Programming/C#/AdventOfCode2021/AdventOfCode2021/AdventOfCode2021/Day2/Measurements.txt";

        public Day2_Dive()
        {
        }

        public static int GetSolutionPuzzleOne()
        {
            string[] course = File.ReadAllLines(measurementsFilePath);
            int horizontalPosition = 0;
            int depth = 0;

            foreach(string line in course)
            {
                string[] directions = line.Split(" ");

                switch (directions[0])
                {
                    case "forward":
                        horizontalPosition += int.Parse(directions[1]);
                        break;
                    case "down":
                        depth += int.Parse(directions[1]);
                        break;
                    case "up":
                        depth -= int.Parse(directions[1]);
                        break;
                    default:
                        break;
                }
            }

            return horizontalPosition * depth;
        }

        public static int GetSolutionPuzzleTwo()
        {
            string[] course = File.ReadAllLines(measurementsFilePath);

            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;

            foreach (string line in course)
            {
                string[] directions = line.Split(" ");

                switch (directions[0])
                {
                    case "forward":
                        horizontalPosition += int.Parse(directions[1]);
                        depth += (aim * int.Parse(directions[1]));
                        break;
                    case "down":
                        aim += int.Parse(directions[1]);
                        break;
                    case "up":
                        aim -= int.Parse(directions[1]);
                        break;
                    default:
                        break;
                }
            }

            return horizontalPosition * depth;

        }


    }




}
