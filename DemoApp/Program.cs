using System;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ваше ім'я: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"\nВітаю {userName}!");

            Console.ReadKey();
        }
    }
}
