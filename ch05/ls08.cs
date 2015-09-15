using System;

class Word1
{
    public char[] word = new char[7];

    public virtual char this[int i]
    {
        get
        {
            return word[i];
        }
        set
        {
            if (i >= 0)
                word[i] = value;
        }
    }
}

class Word2 : Word1
{
    public override char this[int i]
    {
        get
        {
            return word[i];
        }
        set
        {
            if (i >= 3)
                word[i] = value;
        }
    }
}


class WordSample
{
    static void Main()
    {
        Word2 word2 = new Word2();

        word2[0] = 'k';
        word2[1] = 'e';
        word2[2] = 'y';
        word2[3] = 'w';
        word2[4] = 'o';
        word2[5] = 'r';
        word2[6] = 'd';

        int i;
        for (i = 0; i <= 6; i++)
        {
            Console.WriteLine(word2[i]);
        }
        Console.Write("\n");


    }
}