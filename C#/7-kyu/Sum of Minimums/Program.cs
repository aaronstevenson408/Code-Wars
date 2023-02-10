/* 
Given a 2D ( nested ) list(array, vector, ..) of size m * n, your task is to find the sum of the minimum values in each row.

For Example:

[ [ 1, 2, 3, 4, 5 ]        #  minimum value of row is 1
, [ 5, 6, 7, 8, 9 ]        #  minimum value of row is 5
, [ 20, 21, 34, 56, 100 ]  #  minimum value of row is 20
]
So the function should return 26 because the sum of the minimums is 1 + 5 + 20 = 26.

Note: You will always be given a non-empty list containing positive values.

ENJOY CODING :)
*/

using System;
using System.Linq;
using System.Xml.Schema;

namespace Solution
{
    class Kata
    {
        public static int SumOfMinimums(int[,] numbers)
        { 
            int total = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int minimun = int.MaxValue; //  make the minimum to the largest int value so the first iteration of the loop is always lower, and that we always have something to compare to.
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    minimun = Math.Min(numbers[i, j], minimun);

                }
                total += minimun;

            }

            return total;
        }
    }
}