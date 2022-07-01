using System;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Программа кратные числа:");

            Random random = new Random();
            int sum = 0;
            int threeDigitNumber = 99;
            int finitNumber = 1000;
            int initialNumber = 1;
            int lastNumber = 27;

            int number = random.Next(initialNumber, lastNumber);

            for (int i = 0; i < finitNumber; i += number)
            {
                if (i > threeDigitNumber)
                {
                    sum++;
                }
            }

            Console.WriteLine("\n Количество трехзначных натуральных чисел sum = " + sum + ", которые кратны N = " + number + ".");
        }
    }
}