using System;
namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string numinput = Console.ReadLine();
            double num = double.Parse(numinput);
            Console.WriteLine($"Вы ввели число {num}");
        }
    }
}

