/*Name Array Capping

https://www.codewars.com/kata/5356ad2cbb858025d800111d

Create a method that accepts an array of names, and returns an array of each name with its first letter capitalized.

example

Kata.CapMe(new string[] { "jo", "nelson", "jurie" })     => new string[] { "Jo", "Nelson", "Jurie" }
Kata.CapMe(new string[] { "KARLY", "DANIEL", "KELSEY" }) => new string[] { "Karly", "Daniel", "Kelsey" }*/

using System;
using System.Linq;

public static class Kata
{
    public static string[] CapMe(string[] strings)
    {
        return strings.Select(x => x.Substring(0, 1).ToUpper() + x.Substring(1).ToLower()).ToArray();
    }
}

/*Best practice and clever solution:

using System.Linq;

public static class Kata
{
    public static string[] CapMe(string[] strings)
    {
        return strings.Select(s => char.ToUpper(s[0]) + s[1..].ToLower()).ToArray();
    }
}*/