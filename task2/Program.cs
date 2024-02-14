// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку,
//  в которой все заглавные буквы заменены на строчные.

using System;
namespace MatricesAndStrings
{
    class Task2
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("введите строку содержащую латинские буквы в обоих регистрах:   ");
            string set = Console.ReadLine()!;
            Console.WriteLine($"строка после ввода: {set}");
            char[] chars = new char[set.Length];
            for (int i = 0; i < set.Length; i++)
            {
                chars[i] = char.ToLower(set[i]);
            }
            Console.WriteLine($"строка после преобразования: {string.Join("", chars)}");
        }
    }
}
            


