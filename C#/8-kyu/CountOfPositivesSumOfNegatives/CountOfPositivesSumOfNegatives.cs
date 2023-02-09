/*
Given an array of integers.

Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.

If the input is an empty array or is null, return an empty array.

Example
For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].
*/
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
     public static int[] CountPositivesSumNegatives(int[] input)
    {
        int[] answer = new int[2];
        int positiveCount = 0;
        int negativeTotal = 0;

        if (input == null || input.Length == 0)
        {
            answer = new int[] { };
            return answer;
        }
        else
        {

            foreach (var number in input)
            {
                if (Math.Sign(number) == 1)
                {
                    positiveCount++;
                }
                else if (Math.Sign(number) == -1)
                {
                    negativeTotal += number;
                }
            }

            answer[0] = positiveCount;
            answer[1] = negativeTotal;

            return answer; //return an array with count of positives and sum of negatives
        }   
    }
}