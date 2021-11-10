using System;

namespace ConsoleApp1
{
    public class Cycles
    {
        static void Main(string[] args)
        {
            // Сумма первых N членов арифм. прогрессии
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            
            Console.WriteLine(sum);
            
            // Факториал
            int p = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int i = 1;
            do
            {
                fact *= i;
                i++;
            } while (i <= p);
            
            Console.WriteLine(fact);
            
            // Количество и сумма парных чисел в диапазоне от 1 до N
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;
                }
            }
            
            Console.WriteLine(count);
            Console.WriteLine(sum);
            
            // Прямоугольный треугольник из звездочек
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
            // Таблица умножения от 2 до 6
            for (int i = 2; i <= 6; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = " + (i * j));
                }
            
                Console.WriteLine();
            }
        }
    }
}