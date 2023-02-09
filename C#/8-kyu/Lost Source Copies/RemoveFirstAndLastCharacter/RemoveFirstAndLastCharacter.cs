/* It's pretty straightforward. Your goal is to create a function that removes 
the first and last characters of a string. You're given one parameter, the original string.
 You don't have to worry with strings with less than two characters.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string Remove_char(string s)
    {
        List<char> charArrayList = new List<char>();
        char[] charArray= s.ToCharArray();
        charArrayList = charArray.ToList(); 
        charArrayList.RemoveAt(0);
        charArrayList.RemoveAt(charArrayList.Count - 1);
        string charString = new string(charArrayList.ToArray());

        return charString;
    }
}