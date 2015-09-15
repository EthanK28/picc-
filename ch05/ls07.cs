using System;

class Greeting
{
    public virtual void bye()
    {
        Console.WriteLine("good bye");
    }
}

class Aisatsu : Greeting
{
    public override void bye()
    {
        Console.WriteLine("안녕히가세요");
    }

    public void cheer()
    {
        Console.WriteLine("건강하세요!");
    }
}

class Owakara
{
    public static void Main()
    {
        Aisatsu aisatsu = new Aisatsu();
        aisatsu.bye();
        aisatsu.cheer();
    }
}
