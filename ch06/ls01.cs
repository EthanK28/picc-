using System;

abstract class clacA
{
    public int a;
    public int b;
    public abstract void answer();

    public void setData(int m, int n)
    {
        a = m;
        b = n;
    }
}

class Plus : clacA
{
    public override void answer()
    {
        Console.WriteLine(a + "+" + b + "=" + (a + b));
    }
}

class AbstSample
{
    static void Main()
    {
        Plus plus = new Plus();
        plus.setData(27, 32);
        plus.answer();
    }
}
