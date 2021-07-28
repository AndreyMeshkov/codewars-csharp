/*Broken Counter

https://www.codewars.com/kata/526471539d52735c620000c6

Our counter prototype is broken. Can you spot, what's wrong here?
*/
public class Counter
{
    private int _Value;
    public int Value
    {
        get
        {
            return _Value;
        }
        private set
        {
            _Value = value;
        }
    }

    public Counter()
    {
        Value = 0;
    }

    public void Increase()
    {
        Value++;
    }

    public void Reset()
    {
        Value = 0;
    }
}

/*Best practice:

public class Counter
{
    private int _Value;
    public int Value
    {
        get
        {
            return _Value;
        }
        private set
        {
            _Value = value;
        }
    }

    public Counter()
    {
        Value = 0;
    }

    public void Increase()
    {
        Value++;
    }

    public void Reset()
    {
        Value = 0;
    }
}

Clever solution:

public class Counter
{
    private int _value;
    public int Value
    {
        get => _value;
        private set => _value = value;
    }

    public void Increase() => Value++;
    public void Reset() => Value = 0;
}*/