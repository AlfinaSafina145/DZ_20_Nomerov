using System;
namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            string num1_input = Console.ReadLine();
            int num1 = int.Parse(num1_input);
            Console.WriteLine("Введите второе число:");
            string num2_input = Console.ReadLine();
            int num2 = int.Parse(num2_input);
            double sr_ar = (num1  + num2) / 2.0;
            double sr_geom = Math.Sqrt((num1 * num2));
            Console.WriteLine($"Среднее арифметическое: {sr_ar}");
            Console.WriteLine($"Среднее геометрическое: {sr_geom}");
        }
    }
}

