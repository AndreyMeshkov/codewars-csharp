/*Convert number to reversed array of digits

https://www.codewars.com/kata/5583090cbe83f4fd8c000051

Convert number to reversed array of digits
Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

Example:
348597 => [7,9,5,8,4,3] */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            return n.ToString().Reverse().Select(x => Convert.ToInt64(x.ToString())).ToArray();
        }
    }
}

/*Best practice and clever solution:

using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            return n.ToString()
                    .Reverse()
                    .Select(t => Convert.ToInt64(t.ToString()))
                    .ToArray();
        }
    }
}*/