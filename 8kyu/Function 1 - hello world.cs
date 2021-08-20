/*Function 1 - hello world

https://www.codewars.com/kata/523b4ff7adca849afe000035/train/csharp

Description:
Make a simple function called greet that returns the most-famous "hello world!".

Style Points
Sure, this is about as easy as it gets. But how clever can you be to create the most creative hello world you can think of? What is a "hello world" solution you would want to show your friends?*/

public static class Kata
{
    public static string greet()
    {
        return "hello world!";
    }
}

/*Best practice:

public static class Kata
{
    public static string greet() => "hello world!";
}*/

/*Clever solution:

public static class Kata
{
    public static string greet()
    {
        string[] array = new string[]
        {
      $"{(char)104}{(char)101}{(char)108}{(char)108}{(char)111}",
      $"{(char)119}{(char)111}{(char)114}{(char)108}{(char)100}{(char)33}"
        };
        return string.Join(" ", array);
    }
}*/