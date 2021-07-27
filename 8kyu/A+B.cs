/*A + B

https://www.codewars.com/kata/5512a0b0509063e57d0003f5

Vasya Pupkin just started learning Java and C#. At first, he decided to write simple program that was supposed to sum up two small numbers (numbers and their sum fit in a byte), but it didn't work. Vasya was too sad to find out what is wrong. Help him to correct the mistake.*/

public class FirstClass
{
    public static byte sum(byte a, byte b)
    {
        byte c = (byte)(a + b);
        return c;
    }
}

/*Best practice:

public class FirstClass
{
    public static byte sum(byte a, byte b)
    {
        byte c = (byte)(a + b);
        return c;
    }
}

Clever solution:

public class FirstClass
{
    public static byte sum(byte a, byte b)
    {
        byte c = b;
        return c += a;
    }
}*/