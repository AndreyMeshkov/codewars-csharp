/*Vowel Count

https://www.codewars.com/kata/54ff3102c1bad923760001f3

Return the number (count) of vowels in the given string.

We will consider a, e, i, o, u as vowels for this Kata (but not y).

The input string will only consist of lower case letters and/or spaces.*/

using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        string vowels = "aeiou";

        for (int i = 0; i < str.Length; i++)
        {
            if (vowels.IndexOf(str[i]) > -1)
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }
}

/*Best practice and clever solution:

using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        return str.Count(i => "aeiou".Contains(i));
    }
}*/