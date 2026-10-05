using System;
namespace Task6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите высоту равнобедренной трапеции: ");
            string hight = Console.ReadLine();
            Console.WriteLine("Введите первое основание равнобедренной трапеции: ");
            string base1 = Console.ReadLine();
            Console.WriteLine("Введите второе основание равнобедренной трапеции: ");
            string base2 = Console.ReadLine();
            double hight_ = double.Parse(hight);
            double base_1 = double.Parse(base1);
            double base_2 = double.Parse(base2);
            double catet1;
            if (base_1 < base_2)
            {
                catet1 = (double)(base_2 - base_1) / 2.0;
            }
            else
            {
                catet1 = (double)(base_1 - base_2) / 2.0;
            }
            double catet2 = Math.Sqrt(hight_ * hight_ + catet1 * catet1);
            double perimetr = base_1 + base_2 + catet2 * 2;
            Console.WriteLine($"Периметр равен {perimetr}");
            Console.ReadKey();

        }
    }
}
