using System;

namespace Day1
{
    class Adventure
    {
        static void Main(String []args)
        {
            String[] lines = readLines(args != null && args.Length > 0);

            int incrementCount = countDepthIncrements(Array.ConvertAll(lines, s => int.Parse(s)));

            Console.WriteLine("Increment count is " + incrementCount);
        }

        static String[] readLines(Boolean test)
        {
            String inputFile = "input.txt";
            if (test) {
                inputFile = "test.txt";
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), inputFile);

            string[] lines = System.IO.File.ReadAllLines(inputFile);
            return lines;
        }

        static int countDepthIncrements(int[] lines)
        {
            int prev = -1;
            int count = 0;
            for (int i = 0;i < lines.Length;i++) {
                Console.WriteLine(lines[i] + " > " + prev);
                if (lines[i] > prev && prev != -1)
                    count++;
                prev = lines[i];
            }
            return count;
        }
    }
}