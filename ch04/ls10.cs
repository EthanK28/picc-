using System;

class Book
{
    public int price;
    public int num = 0;
    public string title;

    public Book(string t, int p)
    {
        title = t;
        price = p;
    }

    public void print()
    {
        Console.WriteLine("제 목: " + title);
        Console.WriteLine("정 가: " + price);
        Console.WriteLine("주문부수: " + num);
        Console.WriteLine("합계금액: " + price * num);
    }
}

class Books
{
    static void Main()
    {
        Book book = new Book("C 그림책", 14000);
        book.num = 10;
        book.print();
    }
}