using System;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число:");
            string num1input = Console.ReadLine();
            double num1 = double.Parse(num1input);
            Console.Write("Введите второе число:");
            string num2input = Console.ReadLine();
            double num2 = double.Parse(num2input);
            Console.WriteLine($"До обмена: num1 = {num1}, num2 = {num2}");
            double x = 0;
            x = num1;
            num1 = num2;
            num2 = x;
            Console.WriteLine($"После обмена: num1 = {num1}, num2 = {num2}");
        }
    }
}

