using System;
namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь: Привет!");
            Console.Write("Консоль: Как тебя зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Консоль: Привет, {name}!");
            Console.ReadLine(); //Пользователь: Ты знаешь что-то о тайной комнате?
            Console.WriteLine("Консоль: Да.");
            Console.ReadLine(); // Пользователь: Можешь рассказать?
            Console.WriteLine("Консоль: Нет.");
            Thread.Sleep(5000);
            Console.WriteLine("Консоль: но могу показать.");
            Random rnd = new Random();
            int randomColorIndex = rnd.Next(0, 16); // Получаем случайное число от 0 до 15 (всего 16 стандартных цветов консоли)
            Console.ForegroundColor = (ConsoleColor)randomColorIndex;
            Console.WriteLine("...Цвет изменен...");
            Console.ResetColor();
        }
    }
}

