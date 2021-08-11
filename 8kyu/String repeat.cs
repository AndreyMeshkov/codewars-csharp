/*String repeat

https://www.codewars.com/kata/57a0e5c372292dd76d000d7e

Write a function called repeatStr which repeats the given string string exactly n times.

repeatStr(6, "I") // "IIIIII"
repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"*/

using System.Linq;

namespace Solution
{
	public static class Program
	{
		public static string RepeatStr(int n, string s)
		{
			return string.Concat(Enumerable.Repeat(s, n));
		}
	}
}

/*Best practice and clever solution:

namespace Solution
{
	using System;
	using System.Linq;
	public static class Program
	{
		public static string repeatStr(int n, string s)
		{
			return String.Concat(Enumerable.Repeat(s, n));
		}
	}
}*/