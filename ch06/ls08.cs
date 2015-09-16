using System;

namespace Tokyo
{
    class Tokyotower
    {
        public void print()
        {
            Console.WriteLine("도쿄 타워");
        }
    }
    namespace Toshima
    {
        class Sunshine
        {
            public void print()
            {
                Console.WriteLine("산샤인60");
            }
        }
    }
}

class TokyoSpots
{
    static void Main()
    {
        Tokyo.Tokyotower tower = new Tokyo.Tokyotower();
        Tokyo.Toshima.Sunshine sunshine = new Tokyo.Toshima.Sunshine();
        tower.print();
        sunshine.print();
    }
}
