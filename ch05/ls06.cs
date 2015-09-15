using System;

class A
{
    public int a = 3;
}

class B : A
{
    new public int a = 100;
    public void print()
    {
        Console.WriteLine("A 클래스의 a는 " + base.a);
    }
}

class C
{
    public static void Main()
    {
        B b = new B();
        b.print();
    }

}