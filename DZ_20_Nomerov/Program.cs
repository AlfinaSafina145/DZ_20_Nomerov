using System;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num1 = random.Next();
            int num2 = random.Next();
            int num3 = random.Next();
            int num4 = random.Next();
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
        }
    }
}

