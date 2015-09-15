using System;

class Cat {
    string name;
    string place;
    int age;

    public void setData(string n, string p, int a) {
        name = n;
        place = p;
        age = a;
    }

    public void print() {
        Console.WriteLine(place + ":" + name + " " + age + "세");
    }

    public void print(string p, int a)
    {
        place = p;
        Console.WriteLine(place + ": 고양이는" + a + "마리입니다.");
    }

    public void print(string variery) {
        Console.WriteLine(place + ":" + name + " " + age + "세" + variery);
    }

}

class Pet
{
    static void Main()
    {
        Cat cat1 = new Cat();
        Cat cat2 = new Cat();
        Cat cat3 = new Cat();

        cat1.setData("로빈", "집", 10);
        cat2.setData("꼬마", "이웃", 14);
        cat1.print("잡종");
        cat2.print();
        cat3.print("집", 0);
    }
}