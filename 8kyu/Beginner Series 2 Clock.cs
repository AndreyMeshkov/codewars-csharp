/*Beginner Series #2 Clock

https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a

Clock shows h hours, m minutes and s seconds after midnight.

Your task is to write a function which returns the time since midnight in milliseconds.

Example:
h = 0
m = 1
s = 1

result = 61000
Input constraints:

0 <= h <= 23
0 <= m <= 59
0 <= s <= 59*/

using System;
public static class Clock
{
	public static int Past(int h, int m, int s)
	{
		return (h * 3600 + m * 60 + s) * 1000;
	}
}

/*Best practice and clever solution:

 using System;
  public static class Clock
{
	public static int Past(int h, int m, int s)
	{
		return (int)(new TimeSpan(h, m, s)).TotalMilliseconds;
	}
}*/