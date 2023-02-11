/* 
 * What if we need the length of the words separated by a space to be added at the end of that same word and have it returned as an array?

Example(Input --> Output)

"apple ban" --> ["apple 5", "ban 3"]
"you will win" -->["you 3", "will 4", "win 3"]
Your task is to write a function that takes a String and returns an Array/list with the length of each word added to each element .

Note: String will have at least one element; words will always be separated by a space.
*/

using System;
using System.Linq;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing SampleTest: " + (new string[] { "apple 5", "ban 3" } == Kata.AddLength("apple ban")));
            Console.WriteLine("Testing SampleTest: " + (new string[] { "you 3", "will 4", "win 3" } == Kata.AddLength("you will win")));
        }
    }
    public class Kata
    {
        public static string[] AddLength(string str)
        {
            List<string> words = new List<string>();
            List<string> wordsModified = new List<string>(); // there has to be a better way to do thi
            words = str.Split(" ").ToList();
            string[] wordsArray = new string[words.length - 1];
            foreach (string word in words)
            {
                wordsArray.Append(word + " " + word.Length);
            }
           
        }
    }

}