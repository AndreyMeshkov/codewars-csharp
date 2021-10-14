/*Count of positives / sum of negatives

https://www.codewars.com/kata/576bb71bbbcf0951d5000044

Given an array of integers.

Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers.

If the input array is empty or null, return an empty array.

Example
For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
	public static int[] CountPositivesSumNegatives(int[] input)
	{
		if (input == null || input.Length == 0)
		{
			return new int[] { };
		}
		int positiveSum = input.Where(item => item > 0).Count();
		int negativeSum = input.Where(item => item < 0).Sum();
		return new int[] { positiveSum, negativeSum };
	}
}

/*Best practice:

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (input == null || !input.Any())
        {
            return new int[] { };
        }

        int countPositives = input.Count(n => n > 0);
        int sumNegatives = input.Where(n => n < 0).Sum();

        return new int[] { countPositives, sumNegatives };
    }
}*/

/*Clever solution:

using System;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        return (input == null || input.Length == 0) ? new int[0] : new int[] { input.Count(o => o > 0), input.Where(o => o < 0).Sum() };
    }
}*/
