using System;
using System.Collections.Generic;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExploreIf();
            // ExploreWhileLoop();
            // DoWhileLoop();
            // ForLoop();
            // FindSum();
            GenericList();
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
        static void ExploreWhileLoop()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! Counter = {counter}");
                counter++;
            }
        }
        static void DoWhileLoop()
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"Do while loop... Counter = {counter}");
                counter++;
            } while (counter < 10);
        }
        static void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"For loop... Counter = {i}");
            }
        }
        static void FindSum()
        {
            int sum = 0;
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 == 0)
                {
                    // Console.WriteLine($"Number {i} is divisible by 3");
                    sum = sum + i;
                }
                else
                {
                    // Console.WriteLine($"Number {i} is NOT divisible by 3");
                }
            }
            Console.WriteLine($"The sum is = {sum}");
        }
        static void GenericList()
        {
            var names = new List<string> { "Santosh", "Roopa", "Sukruthi" };
            foreach( var name in names) {
                Console.WriteLine(name);
            }
        }
    }
}
