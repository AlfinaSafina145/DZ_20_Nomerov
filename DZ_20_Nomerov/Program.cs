using System;
namespace Task20
{
    class Program
    {
        static int CalculateEAN13(int[] digits)
        {
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    sumOdd += digits[i];
                }
                else
                {
                    sumEven += digits[i];
                }
            }
            int totalSum = sumOdd + (sumEven * 3);
            int remainder = totalSum % 10;
            if (remainder == 0)
            {
                return 0;
            }
            else
            {
                return 10 - remainder;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Пункт a");
            int[] digits = new int[12];
            Random rnd = new Random();
            Console.Write("Сгенерированный код: ");
            for (int i = 0; i < 12; i++)
            {
                digits[i] = rnd.Next(0, 10);
                Console.Write(digits[i]);
            }
            int checkDigit = CalculateEAN13(digits);
            Console.WriteLine();
            Console.WriteLine($"Контрольная цифра: {checkDigit}");

            Console.WriteLine("Пункт б");
            Console.Write("Введите 12 цифр штрихкода (без пробелов): ");
            string input = Console.ReadLine();
            for (int i = 0; i < 12; i++)
            {
                string oneDigit = input.Substring(i, 1);
                digits[i] = int.Parse(oneDigit);
            }
            int checkDigit1 = CalculateEAN13(digits);
            Console.Write(checkDigit1);
        }
    }
}

