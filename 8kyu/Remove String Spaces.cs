Remove String Spaces

https://www.codewars.com/kata/57eae20f5500ad98e50002c5/csharp

Simple, remove the spaces from the string, then return the resultant string.

namespace Solution
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }
    }
}

/*Best practice and clever solution:

namespace Solution
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }
    }
}*/