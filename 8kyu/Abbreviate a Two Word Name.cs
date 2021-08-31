/*Abbreviate a Two Word Name

https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3

Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

The output should be two capital letters with a dot separating them.

It should look like this:

Sam Harris => S.H

Patrick Feeney => P.F*/

public class Kata
{
	public static string AbbrevName(string name)
	{
		return $"{name.ToUpper().Split()[0][0]}.{name.ToUpper().Split()[1][0]}";
	}
}

/*Best practice and clever solution:

using System;
using System.Linq;
public class Kata
{
	public static string AbbrevName(string name) => string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();
}*/