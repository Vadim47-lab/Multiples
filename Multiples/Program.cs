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
            int nextNumber = 1;
            int m = 1000;

            int N = random.Next(1, 27);

            for (int i = 0; i < m; i = i + nextNumber + N)
            {
                sum++;
            }

            Console.WriteLine("\n Количество трехзначных натуральных чисел sum = " + sum + ", которые кратны N = " + N + ".");
        }
    }
}