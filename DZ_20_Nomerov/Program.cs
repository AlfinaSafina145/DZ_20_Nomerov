using System;
namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());
            int a1 = a;
            Console.WriteLine("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());
            int b1 = b;
            Console.WriteLine("Введите значение c: ");
            int c = int.Parse(Console.ReadLine());
            int c1 = c;

            Console.WriteLine("Схема а)");
            Console.WriteLine($"До: a={a}, b={b}, c={c}");
            int temp = b;
            b = c;
            c = a;
            a = temp;
            Console.WriteLine($"После: a={a}, b={b}, c={c}");

            Console.WriteLine("Схема b)");
            Console.WriteLine($"До: a={a1}, b={b1}, c={c1}");
            int temp1 = a1;  
            a1 = c1;          
            c1 = b1;
            b1 = temp1;
            Console.WriteLine($"После: a={a1}, b={b1}, c={c1}");
        }
    }
}

