using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Nikita";
            byte MyAge = 30;
            bool HaveIApet = true;
            double MyShoeSize = 46;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.ReadKey();
        }
    }
}
