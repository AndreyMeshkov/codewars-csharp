/*Convert a Number to a String!

https://www.codewars.com/kata/5265326f5fda8eb1160004c8/csharp

We need a function that can transform a number into a string.

What ways of achieving this do you know?

Examples:
123-- > "123"
999-- > "999"*/

using System;

public class Kata
{
    public static string NumberToString(int num)
    {
        return num.ToString();
    }
}

/*Best practice:

using System;

public class Kata
{
    public static string NumberToString(int num)
    {
        return num.ToString();
    }
}*/

/*Clever solution:

using System;

public class Kata
{
    public static string NumberToString(int num)
    {
        return $"{num}";
    }
}*/