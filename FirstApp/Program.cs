using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");

            var name = Console.ReadLine();

            Console.Write("Enter your age: ");

            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is {0} and age is {1}", name, age);

            Console.Write("Enter your birthdate: ");

            var birthdate = Console.ReadLine();

            Console.WriteLine("Your birthdate is {0}", birthdate);

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
