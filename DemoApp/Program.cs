using System;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ваше ім'я: ");
            string userName = Console.ReadLine();

             Console.Write("Введіть ваш вік: ");
            string userAgeInput = Console.ReadLine();
            int userAge;
            if (int.TryParse(userAgeInput, out userAge))
            {
                Console.WriteLine($"\nВітаю {userName}!");
                Console.WriteLine($"Ваш вік: {userAge} років.");
            }
            Console.ReadKey();
        }
    }
}
