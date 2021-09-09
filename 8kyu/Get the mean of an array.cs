/*Get the mean of an array

https://www.codewars.com/kata/563e320cee5dddcf77000158

It 's the academic year's end, fateful moment of your school report. The averages must be calculated. All the students come to you and entreat you to calculate their average for them. Easy ! You just need to write a script.

Return the average of the given array rounded down to its nearest integer.

The array will never be empty.*/

using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
    public static int GetAverage(int[] marks)
    {
        return Enumerable.Sum(marks) / marks.Length;
    }
}

/*Best practice and clever solution:

using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
    public static int GetAverage(int[] marks)
    {
        return (int)marks.Average();
    }
}*/