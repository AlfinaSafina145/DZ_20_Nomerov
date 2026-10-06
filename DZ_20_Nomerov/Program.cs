using System;
namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 543; 
            int side = 130;   

            int count = length / side;

            Console.WriteLine($"Можно отрезать квадратов: {count}");
        }
    }
}

