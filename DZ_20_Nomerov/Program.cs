using System;
namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n % 10;
            int restOfNumber = n / 10;
            int result = (lastDigit * 100) + restOfNumber;
            Console.WriteLine($"Полученное число: {result}");
            
        }
    }
}

