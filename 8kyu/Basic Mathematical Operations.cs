/*Basic Mathematical Operations

https://www.codewars.com/kata/57356c55867b9b7a60000bd7

Your task is to create a function that does four basic mathematical operations.

The function should take three arguments - operation(string/char), value1(number), value2(number).
The function should result   = result   of numbers after applying the chosen operation.

Examples
basic_op('+', 4, 7)         # Output: 11
basic_op('-', 15, 18)       # Output: -3
basic_op('*', 5, 5)         # Output: 25
basic_op('/', 49, 7)        # Output: 7*/

namespace Solution
{
    public static class Program
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '+': return value1 + value2;
                case '-': return value1 - value2;
                case '*': return value1 * value2;
                case '/': return value1 / value2;
                default: throw new System.ArgumentException("Invalid operation.", nameof(operation));
            }
        }
    }
}

/*Best practice:

namespace Solution
{
    public static class Program
    {
        public static double basicOp(char op, double val1, double val2)
        {
            switch (op)
            {
                case '+': return val1 + val2;
                case '-': return val1 - val2;
                case '*': return val1 * val2;
                case '/': return val1 / val2;
                default:
                    throw new System.ArgumentException("Unknown operation!", op.ToString());
            }
        }
    }
}*/

/*Clever solution:

namespace Solution
{
    using System;
    using System.Collections.Generic;

    public static class Program
    {
        public static double basicOp(char op, double val1, double val2)
        {
            return new Dictionary<char, Func<double, double, double>>()
      {
          { '+', (a, b) => a + b },
          { '-', (a, b) => a - b },
          { '*', (a, b) => a * b },
          { '/', (a, b) => a / b }
      }[op](val1, val2);
        }
    }
}*/