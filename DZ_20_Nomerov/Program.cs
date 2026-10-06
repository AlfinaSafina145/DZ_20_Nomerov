using System;
namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("а) Введите ваше имя: ");
            string nameA = Console.ReadLine();
            Console.WriteLine($"Введенное имя: {nameA}");
            Console.WriteLine();
            Console.Write("б) Введите ваше имя: ");
            string nameB = Console.ReadLine();
            Console.WriteLine($"Привет, {nameB}!");
        }
    }
}

