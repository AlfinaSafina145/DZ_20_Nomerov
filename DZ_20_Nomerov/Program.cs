using System;
namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x1:");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y1:");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату x2:");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y2:");
            double y2 = double.Parse(Console.ReadLine());

            double raz_X = x2 - x1;
            double raz_Y = y2 - y1;

            double distance = Math.Sqrt(raz_X * raz_X + raz_Y * raz_Y);
            Console.WriteLine($"Расстояние между координатами равно: {distance}");
        }
    }
}

