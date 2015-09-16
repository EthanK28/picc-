using System;

interface Greet
{
    void greet();
}

interface Bye : Greet
{
    void bye();
}

class Greeting : Bye
{
    public void greet()
    {
        Console.WriteLine("안녕하세요!");
    }

    public void bye()
    {
        Console.WriteLine("안녕히 가세요");
    }
}

class Meet
{
    static void Main()
    {
        Greeting greeting = new Greeting();
        greeting.greet();
        greeting.bye();
    }
}