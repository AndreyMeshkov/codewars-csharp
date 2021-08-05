/*Convert boolean values to strings 'Yes' or 'No'

https://www.codewars.com/kata/53369039d7ab3ac506000467

Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.*/

using System;
using System.Linq;

public static class Kata
{
    public static string boolToWord(bool word)
    {
        return word ? "Yes" : "No";
    }
}

/*Best practice:

using System;
using System.Linq;

public static class Kata
{
    public static string boolToWord(bool word)
    {
        return word ? "Yes" : "No";
    }
}*/

/*Clever solution:

using System;
using System.Linq;

public static class Kata
{
    public static string boolToWord(bool word) => word ? "Yes" : "No";
}*/