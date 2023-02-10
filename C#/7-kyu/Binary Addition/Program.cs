using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing the solution for 1 + 2");
            string result = Kata.AddBinary(1, 2);
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Expected result: 11");
            Console.WriteLine("Comparing the result with expected result...");
            Console.WriteLine(result == "11" ? "Test passed!" : "Test failed!");
        }
    }
    public static class Kata
    {
        public static string AddBinary(int a, int b)
        {
            int sum = a + b;
            string resultString = string.Empty;
            while (sum >= 1)
            {
                int resultInt = sum % 2;
                resultString = String.Concat(resultInt, resultString);
                sum /= 2;
            }

            return resultString;
        }
    }
}