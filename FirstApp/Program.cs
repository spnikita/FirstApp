using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek MyFavoriteDay;

            MyFavoriteDay = DaysOfWeek.Friday;

            Console.WriteLine(MyFavoriteDay);

            Console.ReadKey();
        }
    }

    enum DaysOfWeek : byte
    {
        Tuesday,
        Monday,
        Wednesday,
        Friday
    }
}
