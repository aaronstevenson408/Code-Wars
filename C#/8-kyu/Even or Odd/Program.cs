using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expectedOutputs = { "Even", "Odd", "Even", "Odd", "Odd" };

            int[] inputs = { 2, 1, 0, 7, -1 };

            for (int i = 0; i < inputs.Length; i++)
            {
                string output = SolutionClass.EvenOrOdd(inputs[i]);
                Console.WriteLine("Input: " + inputs[i] + ", Output: " + output + ", Expected: " + expectedOutputs[i]);

                if (output == expectedOutputs[i])
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
                Console.WriteLine();
            }
        }
    }
    public class SolutionClass
    {
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else 
            {
                return "Odd";
            }
        }
    }
}
