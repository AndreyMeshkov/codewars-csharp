/*Counting sheep...

https://www.codewars.com/kata/54edbc7200b811e956000556/csharp

Consider an array/list of sheep where some sheep may be missing from their place. We need a function that counts the number of sheep present in the array (true means present).

For example,

[true, true, true, false,
  true, true, true, true,
  true, false, true, false,
  true, false, false, true,
  true, true, true, true,
  false, false, true, true]
The correct answer would be 17.

Hint: Don 't forget to check for bad values like null/undefined*/

using System;

public static class Kata
{
	public static int CountSheeps(bool[] sheeps)
	{
		int result = 0;
		for (int i = 0; i < sheeps.Length; i++)
		{
			if (sheeps[i])
			{
				result++;
			}
		}
		return result;
	}
}

/*Best practice and clever solution:

using System;
using System.Linq;

public static class Kata
{
	public static int CountSheeps(bool[] sheeps)
	{
		return sheeps.Count(s => s);
	}
}*/