using System;

class Cat
{
    private string a = "Shiro";
    string b = "Tama";
    public string c = "Tora";
}

class Catnames
{
    static void Main()
    {
        Cat name = new Cat();

        Console.WriteLine(name.a);
        Console.WriteLine(name.b);
        Console.WriteLine(name.c);

    }
}
