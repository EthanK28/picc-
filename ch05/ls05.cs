using System;

class Calc1
{
    public int x;
    public Calc1(int a, int b)
    {
        x = a + b;
    }
}

class Calc2 : Calc1
{
    public Calc2(int c, int d) : base(c, d) { }
}

class Calc3
{
    public static void Main()
    {
        Calc2 calc2 = new Calc2(1, 2);
        Console.WriteLine(calc2.x);
    }
}