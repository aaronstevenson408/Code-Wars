//This function should return an object, but it's not doing what's intended. What's wrong?


using System.Collections.Generic;
public class Kata
{
    public static Dictionary<string, string> Mystery()
    {
        Dictionary<string, string> results = new Dictionary<string,string>();

        results.Add("sanity", "hello");
        return results; // there was a semicolon after return that caused the dictionary not to be passed
    }
}