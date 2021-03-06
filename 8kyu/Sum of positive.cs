/*Sum of positive

https://www.codewars.com/kata/5715eaedb436cf5606000381

You get an array of numbers, return the sum of all of the positives ones.

Example [1,-4,7,12] => 1 + 7 + 12 = 20

Note: if there is nothing to sum, the sum is default to 0.*/

using System;
using System.Linq;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                result += arr[i];
            }
        }
        return result;
    }
}

/*Best practice and clever solution:

using System;
using System.Linq;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        return arr.Where(x => x > 0).Sum();
    }
}*/
