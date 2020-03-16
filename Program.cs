using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExploreIf();
            ExploreLoop();
        }
        static void ExploreIf()
        {
            int a = 5;
            int b = 4;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is less than 10");
            }
        }

        static void ExploreLoop() {
            int counter = 0;
            while (counter < 10) {
                Console.WriteLine($"Hello World! Counter = {counter}");
                counter++;
            }
        }
    }
}
