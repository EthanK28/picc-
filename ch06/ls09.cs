using System;
using F = Fishing;

namespace Fishing
{
    class Fish
    {
        int num;
        string name;
        public Fish(string m , int n)
        {
            name = m;
            num = n;
        }
        public void print()
        {
            Console.WriteLine(name + " 낚은 수 " + num + "마리");
        }
    }
}

class FishSample
{
    static void Main()
    {
        F.Fish iwashi = new F.Fish("정어리", 12);
        F.Fish fugu = new F.Fish("복어", 5);
        iwashi.print();
        fugu.print();
    }
}