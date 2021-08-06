/*Return Negative

https://www.codewars.com/kata/55685cd7ad70877c23000102/csharp

In this simple assignment you are given a number and have to make it negative.But maybe the number is already negative?

Example:

Kata.MakeNegative(1); // return -1
Kata.MakeNegative(-5); // return -5
Kata.MakeNegative(0); // return 0
Notes:

The number can be negative already, in which case no change is required.
Zero (0) is not checked for any specific sign. Negative zeros make no mathematical sense.*/

using System;

public static class Kata
{
    public static int MakeNegative(int number)
    {
        return number > 0 ? -number : number;
    }
}

/*Best practice and clever solution:

using System;

public static class Kata
{
    public static int MakeNegative(int number)
    {
        return -Math.Abs(number);
    }
}*/