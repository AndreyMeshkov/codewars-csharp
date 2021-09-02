/*Beginner - Lost Without a Map

https://www.codewars.com/kata/57f781872e3d8ca2a000007e

Given an array of integers, return a new array with each value doubled.

For example:

[1, 2, 3] --> [2, 4, 6]*/

public class Kata
{
    public static int[] Maps(int[] x)
    {
        int[] result = new int[x.Length];
        for (int i = 0; i < x.Length; i++)
        {
            result[i] = x[i] * 2;
        }
        return result;
    }
}

/*Best practice and clever solution:

using System.Linq;

public class Kata
{
    public static int[] Maps(int[] x)
    {
        return x.Select(e => e * 2).ToArray();
    }
}*/