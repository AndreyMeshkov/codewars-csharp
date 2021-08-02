/*Filtering even numbers (Bug Fixes)

https://www.codewars.com/kata/566dc566f6ea9a14b500007b

Fix the bug in Filtering method
The method is supposed to remove even numbers from the list and return a list that contains odd number.

However, there is a bug in the method that needs to be resolved.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> FilterOddNumber(List<int> listOfNumbers)
    {
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            if (listOfNumbers[i] % 2 == 0)
            {
                listOfNumbers.RemoveAt(i);
                i--;
            }
        }
        return listOfNumbers;
    }
}

/*Best practice and clever solution:

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> FilterOddNumber(List<int> numbers)
    {
        return numbers.Where(n => n % 2 == 1).ToList();
    }
}*/