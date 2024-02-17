// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
using System;
namespace MatricesAndStrings
{
    class Task3
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("введите строку:   ");
            string set = Console.ReadLine()!;
            // Console.WriteLine($"строка после ввода: {set}");
            char[] chars = new char[set.Length];
            for (int i = 0; i < set.Length; i++)
            {
                chars[i] = set[i];
            }

            // Console.WriteLine($"строка после преобразования: {string.Join(",", chars)}");
            int j = 0;
            while (j < chars.Length / 2)
            {
                if (chars[j] == chars[chars.Length - 1 - j])
                {
                    j++;
                    Console.WriteLine("строка полиндром");
                }
                else Console.WriteLine("строка не полиндром");
                return;
            }


        }
    }
}