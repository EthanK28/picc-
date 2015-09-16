using System;

class ObjectSample
{
    static void Main()
    {
        float b = 3.14F;
        object ab;
        float c;

        Console.WriteLine(b);
        ab = b;
        c = (float)ab;
        Console.WriteLine(c);

    }
}
