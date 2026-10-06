using System;
namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во секунд:");
            long sek = long.Parse(Console.ReadLine());
            long hour = sek / 3600;
            long min = (sek % 3600) / 60 ;
            long seconds = sek % 60;
            Console.WriteLine($"С начала суток прошло {hour} часов");
            Console.WriteLine($"С начала очередного часа прошло {min} минут");
            Console.WriteLine($"С начала очередной минуты прошло {seconds} секунд");
        }
    }
}

