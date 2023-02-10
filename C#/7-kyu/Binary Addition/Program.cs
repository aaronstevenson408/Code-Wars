using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing the solution for 800 + 45");
            string result = Kata.AddBinary(800, 45);
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Expected result: 1101001101");
            Console.WriteLine("Comparing the result with expected result...");
            Console.WriteLine(result == "1101001101" ? "Test passed!" : "Test failed!");
        }
    }
    public static class Kata
    {
        public static string AddBinary(int a, int b)
        {
            int sum = a + b;
            string resultString = string.Empty;
            while (sum > 0)
            {
                int resultInt = sum % 2;
                resultString = String.Concat(resultInt, resultString);
                sum = sum / 2;
            }

            return resultString;
        }
    }
}