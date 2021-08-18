/*Square(n) Sum

https://www.codewars.com/kata/515e271a311df0350d00000f/csharp

Complete the square sum function so that it squares each number passed into it and then sums the results together.

For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.*/

public static class Kata
{
    public static int SquareSum(int[] n)
    {
        int result = 0;
        for (int i = 0; i < n.Length; i++)
        {
            result += n[i] * n[i];
        }
        return result;
    }
}

/*Best practice and clever solution:

using System.Linq;
public static class Kata
{
    public static int SquareSum(int[] n) => n.Sum(i => i * i);
}*/