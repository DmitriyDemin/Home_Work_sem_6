// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
using System;
namespace MatricesAndStrings
{
    class Task1
    {
        public static void Main()
        {
            Console.Clear();
            Console.Write("введите количесво строк в массиве:   ");
            int x = int.Parse(Console.ReadLine()!);
            Console.Write("введите количесво столбцов в массиве:   ");
            int y = int.Parse(Console.ReadLine()!);
            char[,] symbols = new char[x, y];
            Console.WriteLine("введите символ для заполнения массива:  ");
            for (int i = 0; i < x; i++)
            {
                 
                for (int j = 0; j < y; j++)
                {
                    
                    symbols[i, j] = char.Parse(Console.ReadLine()!);
                }
            }

            // for (int i = 0; i < x; i++)
            // {
            //     for (int j = 0; j < y; j++)
            //     {
            //         Console.Write($"{symbols[i, j]} \t");

            //     }
            //     Console.WriteLine();
            // }
            Console.Write("строка из символов:  ");
            string result = "";
            foreach (char element in symbols)
            {
                result += element;
            }
            Console.WriteLine(result);

        }
    }
}
