using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInfo = EnterUserInfo();

            DisplayUserInfo(userInfo);              

            Console.ReadKey();
        }        

        /// <summary>
        /// Ввести информацию о пользователе
        /// </summary>
        /// <returns>Данные пользователя</returns>
        private static (string Name, string LastName, int Age, string[] Pets, string[] FavoriteColors) EnterUserInfo()
        {
            (string Name, string LastName, int Age, string[] Pets, string[] FavoriteColors) user;

            Console.WriteLine("Введите имя");
            user.Name = Console.ReadLine();                                 

            Console.WriteLine("Введите фамилию");
            user.LastName = Console.ReadLine();

            string strAge;
            int age;
            do
            {           
                Console.WriteLine("Введите возраст");
                strAge = Console.ReadLine();              
            } while (!CheckNum(strAge, out age));

            user.Age = age;

            Console.WriteLine("Есть ли у вас питомцы?");
            var petsPresence = string.Equals(Console.ReadLine(), "Да", StringComparison.OrdinalIgnoreCase);

            if (petsPresence)
            {
                string strPetsNumber;
                int petsNumber;
                do
                {
                    Console.WriteLine("Введите количество питомцев");
                    strPetsNumber = Console.ReadLine();
                } while (!CheckNum(strPetsNumber, out petsNumber));

                
                Console.WriteLine("Введите клички животных");
                user.Pets = FillArrayValues(petsNumber);
            }
            else
            {
                user.Pets = new string[0];
            }

            string strColorsNumber;
            int colorsNumber;
            do
            {
                Console.WriteLine("Введите количество любимых цветов");
                strColorsNumber = Console.ReadLine();
            } while (!CheckNum(strColorsNumber, out colorsNumber));

            Console.WriteLine("Введите список любимых цветов");
            user.FavoriteColors = FillArrayValues(colorsNumber);

            return user;
        }

        /// <summary>
        /// Заполнить массив данных
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Массив данных</returns>
        private static string[] FillArrayValues(int size)
        {
            var array = new string[size];

            for (int i = 0; i < array.Length; i++)
            {
                do
                {
                    Console.Write("{0}. ", i + 1);
                    array[i] = Console.ReadLine();
                } while (!CheckStr(array[i]));                           
            }

            return array;
        }

        /// <summary>
        /// Проверить корректность введенного числа
        /// </summary>
        /// <param name="strNumber">Строковое значение числа</param>
        /// <param name="number">Число, конвертированное из строки</param>       
        /// <returns>Число введено корректно, да/нет</returns>
        private static bool CheckNum(string strNumber, out int number)
        {
            /* Можно использовать тип byte, но в задании указано использовать тип int.
             * Во-первых, исключим лишнюю проверку числа на отрицательные значения, т.к. TryParse вернет False.
             * Во-вторых, можно считать, что возраст, количество питомцев и количество любимых цветов вряд ли превысит 255 штук.
             */

            var conversionSucceeded = int.TryParse(strNumber, out number);

            if (!conversionSucceeded)
            {
                Console.WriteLine("Ошибка конвертации введенных данных в число. Повторите ввод.");
                return false;
            }
           
            if (number <= 0)
            {
                Console.WriteLine("Число не может быть отрицательным или равно 0. Повторите ввод.");
                return false;
            }                     

            return true;
        }
        
        /// <summary>
        /// Проверить корректность введенной строки
        /// </summary>
        /// <param name="value">Строковое значение</param>
        /// <returns>Строка корректна, да/нет</returns>
        private static bool CheckStr(string value)
        {
            if (value == string.Empty)
            {
                Console.WriteLine("Значение не может быть пустым. Повторите ввод.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Отобразить информацию о пользователе
        /// </summary>
        /// <param name="userInfo">Информация о пользователе</param>
        private static void DisplayUserInfo((string Name, string LastName, int Age, string[] Pets, string[] FavoriteColors) userInfo)
        {
            Console.WriteLine("\tИнформация о пользователе");
            Console.WriteLine("Имя: {0}", userInfo.Name);
            Console.WriteLine("Фамилия: {0}", userInfo.LastName);
            Console.WriteLine("Возраст: {0}", userInfo.Age);
            Console.WriteLine("Домашние животные: {0}", userInfo.Pets.Length > 0 ? string.Join(", ", userInfo.Pets) : "отсутствуют домашние животные");
            Console.WriteLine("Любимые цвета: {0}", string.Join(", ", userInfo.FavoriteColors));
        }
    }
}
