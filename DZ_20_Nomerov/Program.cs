using System;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            string num_input = Console.ReadLine();
            double num = double.Parse(num_input);
            Console.WriteLine(num + 10);

        }
    }
}

