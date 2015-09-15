using System;

class Book
{
    public string title;
    public string genre;

    public void printBook()
    {
        Console.WriteLine("제 목: " + title);
        Console.WriteLine("분 야: " + genre);
    }
}

class Novel : Book
{
    public string writer;
    public void printNov()
    {
        printBook();
        Console.WriteLine("저 자: " + writer);
    }
}

class Magazine : Book
{
    public int day;
    public void printMag()
    {
        printBook();
        Console.WriteLine("발 매 일: " + day + "일");
    }
}

class Bookshelf
{
    public static void Main()
    {
        Novel nov = new Novel();
        nov.title = "시오리의 비경 발견";
        nov.genre = "판타지";
        nov.writer = "앤크";

        Magazine mag = new Magazine();
        mag.title = "월간 C# 그림책";
        mag.genre = "컴퓨터";
        mag.day = 20;

        nov.printNov();
        Console.WriteLine();
        mag.printMag();
    }
}