using System.IO;

namespace AdventOfCode2021.Day1
{
    class Day1_SonarSweep
    {
        private static string measurementsFilePath = "C:/Users/rickn/Documents/Programming/C#/AdventOfCode2021/AdventOfCode2021/AdventOfCode2021/Day1/Measurements.txt";

        public Day1_SonarSweep()
        {
        }


        public static int GetSolutionPuzzleOne()
        {
            int count = 0;

            try
            {
                string[] measurements = File.ReadAllLines(measurementsFilePath);
                for (int i = 0; i < measurements.Length - 1; i++)
                {
                    if (int.Parse(measurements[i]) < int.Parse(measurements[i + 1]))
                    {
                        count++;
                    }
                }

                return count;
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException(e.Message);
            }
        }


        public static int GetSolutionPuzzleTwo()
        {
            int count = 0;

            try
            {
                //get measurements as string
                string[] measurements = File.ReadAllLines(measurementsFilePath);

                for (int i = 0; i < measurements.Length - 1; i++)
                {
                    if ((i + 4) > measurements.Length)
                    {
                        return count;
                    }

                    int sum1 = int.Parse(measurements[i]) + int.Parse(measurements[i + 1]) + int.Parse(measurements[i + 2]);
                    int sum2 = int.Parse(measurements[i + 1]) + int.Parse(measurements[i + 2]) + int.Parse(measurements[i + 3]);

                    if (sum2 > sum1)
                    {
                        count++;
                    }
                }

                return count;
            }
            catch (FileNotFoundException e)
            {
                return 0;
            }
        }

    }
}
