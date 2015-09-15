using System;

class Aroma
{
    public double drop;
    public double itteki
    {
        get
        {
            return drop;
        }

        set
        {
            drop = value;
        }
    }
}

class AromaSample
{
    public static void Main()
    {
        Aroma aroma = new Aroma();
        aroma.itteki = 0.05;
        Console.WriteLine("1방울은" + aroma.itteki + "ml입니다");
    }
}