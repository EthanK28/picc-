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
        Console.WriteLine(place + ":" + name + " " + age + "��");
    }

    public void print(string p, int a)
    {
        place = p;
        Console.WriteLine(place + ": ����̴�" + a + "�����Դϴ�.");
    }

    public void print(string variery) {
        Console.WriteLine(place + ":" + name + " " + age + "��" + variery);
    }

}

class Pet
{
    static void Main()
    {
        Cat cat1 = new Cat();
        Cat cat2 = new Cat();
        Cat cat3 = new Cat();

        cat1.setData("�κ�", "��", 10);
        cat2.setData("����", "�̿�", 14);
        cat1.print("����");
        cat2.print();
        cat3.print("��", 0);
    }
}