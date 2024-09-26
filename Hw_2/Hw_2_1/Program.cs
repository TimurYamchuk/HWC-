

using System;
using static System.Console;

class Hw_2_1
{
    static void Main()
    {
        try
        {
            int[] numbers = new int[10];
            Random rng = new Random();

            WriteLine("Исходный массив:");

            // Заполнение массива случайными числами и вывод на экран
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 6); // Случайные числа от 0 до 5
                Write($"{numbers[i]} ");
            }

            // Начинаем процесс "сжатия" массива
            int filledIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0) // Сохраняем только ненулевые элементы
                {
                    numbers[filledIndex++] = numbers[i];
                }
            }

            // Заполняем оставшиеся элементы значениями -1
            for (int i = filledIndex; i < numbers.Length; i++)
            {
                numbers[i] = -1;
            }

            WriteLine("\nСжатый массив:");

            // Вывод "сжатого" массива
            foreach (int num in numbers)
            {
                Write($"{num} ");
            }
        }
        catch (Exception error)
        {
            WriteLine($"Произошла ошибка: {error.Message}");
        }
    }
}
