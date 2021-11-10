using System;
using System.Linq;

namespace ConsoleApp1
{
    public class Arrays
    {
        static void Main(string[] args)
        {
            // Задание 1.1
            var n = Convert.ToInt32(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int max = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine("Max: " + Convert.ToString(max));

            // Задание 1.2
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => decimal.Parse(s));
            decimal sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            
            decimal avg = sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = avg;
                }
            }
            
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            // Задание 2
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int min = array[0];
            int[] positives = new int[]{};
            int[] others = new int[]{};
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = i;
                }
            
                if (array[i] > 0)
                {
                    positives = positives.Concat(new [] { array[i] }).ToArray();
                }
                else
                {
                    others = others.Concat(new [] { array[i] }).ToArray();
                }
            }
            
            foreach (var item in positives)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            
            foreach (var item in others)
            {
                Console.Write(item + " ");
            }

            // Задание 3.1
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += array[i];
                }
            }
            
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine(sum);

            // Задание 3.2
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 15)
                {
                    array[i] = array[i] * 2;
                }
            }
            
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}