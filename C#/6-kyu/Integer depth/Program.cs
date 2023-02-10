/*
 * The depth of an integer n is defined to be how many multiples of n it is necessary to compute before all 10 digits have appeared at least once in some multiple.

example:

let see n=42

Multiple         value         digits     comment
42*1              42            2,4 
42*2              84             8         4 existed
42*3              126           1,6        2 existed
42*4              168            -         all existed
42*5              210            0         2,1 existed
42*6              252            5         2 existed
42*7              294            9         2,4 existed
42*8              336            3         6 existed 
42*9              378            7         3,8 existed
Looking at the above table under digits column you can find all the digits from 0 to 9, Hence it required 9 multiples of 42 to get all the digits. So the depth of 42 is 9. Write a function named computeDepth which computes the depth of its integer argument.Only positive numbers greater than zero will be passed as an input.
*/
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Collections;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing SampleTest1: " + (Kata.ComputeDepth(1) == 10));
            Console.WriteLine("Testing SampleTest2: " + (Kata.ComputeDepth(42) == 9));
            Console.WriteLine("What happens with a negative number: Result :" + Kata.ComputeDepth(-10));
            Console.WriteLine("What happens with a 0 number: Result :" + Kata.ComputeDepth(-10));

        }
    }
    public class Kata
    {
        public static int ComputeDepth(int n)
        {
            // Handle Zeros
            if (n == 0)
            {
                Console.WriteLine("Error , 0 is infinite");
                return 0;
            }
            List<int> numCollector = new List<int>();
            int round = 1;
            // While all the digits aren't collected
            while (numCollector.Count < 10)
            {
                
                
                //First take the integer and multiply it by this rounds number
                int result = Math.Abs(n * round);
                //Take the digits of that result  and make a list of those digits
                List<int> resultDigits = new List<int>();
                char[] digits = result.ToString().ToCharArray();
                foreach (char digit in digits)
                {
                    resultDigits.Add(int.Parse(digit.ToString()));
                }
                //Compare those digits to a list of all found digits
                foreach (int item in resultDigits)
                {
                         if (!numCollector.Contains(item))
                    //If it isn't found add to a list of found digits 
                    {
                        numCollector.Add(item);
                    }
                }
                //Check to see if all digits 0 - 9 are found and if so break from function
                if (numCollector.Count == 10)
                {
                    break; 
                }
                //Return round that was last completed
                round++;
            }
            return round;
        }

    }
}

