/*Square Every Digit

https://www.codewars.com/kata/546e2562b03326a88e000020

Welcome.In this kata, you are asked to square every digit of a number and concatenate them.

For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

Note: The function accepts an integer and returns an integer*/

using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string str = n.ToString();
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            result += Math.Pow(Convert.ToInt32(str[i] - '0'), 2).ToString();
        }
        return Convert.ToInt32(result);
    }
}

/*Best practice:

using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string output = "";
        foreach (char c in n.ToString())
        {
            int square = int.Parse(c.ToString());
            output += (square * square);
        }
        return int.Parse(output);
    }
}*/

/*Clever solution:

using System;
using System.Linq;
public class Kata
{
    public static int SquareDigits(int n)
    {
        return int.Parse(String.Concat(n.ToString().Select(a => (int)Math.Pow(char.GetNumericValue(a), 2))));
    }
}*/