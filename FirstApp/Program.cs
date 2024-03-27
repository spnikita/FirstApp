using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            for (int k = 0; k < 3; k++)
            {

                Console.WriteLine("Введите имя");

                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");

                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                var result = Console.ReadLine();

                User.HasPet = result == "Да";

                Console.WriteLine("Введите возраст пользователя");

                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }

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
}
