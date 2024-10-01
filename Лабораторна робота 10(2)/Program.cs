using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Введіть рядок
        Console.Write("Input row: ");
        string inputString = Console.ReadLine();

        // Розділіть рядок на слова
        string[] words = inputString.Split();

        // Ініціалізуйте список для зберігання Unicode кодів символів кожного слова
        List<List<int>> unicodeCodes = new List<List<int>>();

        // Знайдіть Unicode коди для кожного слова та збережіть їх у списку
        foreach (string word in words)
        {
            List<int> codes = new List<int>();
            foreach (char character in word)
            {
                int code = Convert.ToUInt16(character);
                codes.Add(code);
            }
            unicodeCodes.Add(codes);
        }

        // Знайдіть суму Unicode кодів для кожного слова та виведіть її на консоль
        Console.WriteLine("Суми Unicode кодів для кожного слова:");
        for (int i = 0; i < words.Length; i++)
        {
            int сума = 0;
            foreach (int code in unicodeCodes[i])
            {
                сума += code;
            }

            Console.WriteLine($"{words[i]}: {сума}");
        }
        string maxWord = "";
        int maxSum = 0;

        // Знайти слово з максимальною сумою Unicode кодів
        foreach (string word in words)
        {
            int sum = 0;
            foreach (char character in word)
            {
                sum += (int)character;
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                maxWord = word;
            }
        }

        // Вивести слово з максимальною сумою Unicode кодів символів
        Console.WriteLine($"Word with the maximum sum of Unicode character codes: {maxWord}");
    }
}

