/*Reversed Strings

https://www.codewars.com/kata/5168bb5dfe9a00b126000018

Complete the solution so that it reverses the string passed into it.

'world'  =>  'dlrow'*/

using System;

public static class Kata
{
    public static string Solution(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

/*Best practice and clever solution:

using System;
using System.Linq;

public static class Kata
{
    public static string Solution(string str)
    {
        return new string(str.ToArray().Reverse().ToArray());
    }
}*/