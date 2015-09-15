using System;

class Purse
{
    public static int money = 0;

    public void printMoney (int In, int Out)
    {
        money = money + In - Out;
        if (money < 0)
            Console.WriteLine((-1 * money) + "원 부족합니다.");
        else
            Console.WriteLine("잔금은 " + money + "원이니다.");
    }
}

class Shopping
{
    public static void Main()
    {
        Purse store1 = new Purse();
        Purse store2 = new Purse();
        store1.printMoney(1000, 100 );
        store2.printMoney(0, 250);
        store1.printMoney(0, 800);

    }
}