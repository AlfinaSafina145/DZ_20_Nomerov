using System;
namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число n (n > 999): ");
            int n = int.Parse(Console.ReadLine());
            if (n > 999)
            {
                int hundreds = n / 100;
                int thousands = n / 1000;

                Console.WriteLine($"а) Число сотен: {hundreds}");
                Console.WriteLine($"б) Число тысяч: {thousands}");
            }
            else
            {
                Console.WriteLine("Ошибка: число должно быть больше 999!");
            }
        }
    }
}

