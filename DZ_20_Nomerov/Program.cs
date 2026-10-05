using System;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол в градусах:");
            string xinput = Console.ReadLine();
            double x = double.Parse(xinput);
            double gr_to_rad = x * (double)Math.PI / 180;
            double y = Math.Cos(gr_to_rad);
            Console.WriteLine($"Косинус {x} равен {y}");
        }
    }
}

