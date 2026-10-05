using System;
namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент a квадратного уравнения:");
            string ainput = Console.ReadLine();
            Console.WriteLine("Введите коэффициент b квадратного уравнения:");
            string binput = Console.ReadLine();
            Console.WriteLine("Введите коэффициент c квадратного уравнения:");
            string cinput = Console.ReadLine();
            double a = double.Parse(ainput);
            double b = double.Parse(binput);
            double c = double.Parse(cinput);
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("Вещественных корней нет!");
            }
            else if (D == 0)
            {
                double x_one = -b / (2 * a);
                Console.WriteLine($"Есть только один корень = {x_one}");
            }
            else
            {
                double x1 = (-b + (double)Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - (double)Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Первый корень = {x1}, второй корень = {x2}");
            }
        }
    }
}

