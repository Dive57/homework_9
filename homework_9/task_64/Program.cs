﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int NaturalNumber (int n, int m)
{
  если (n == m) вернуть n;
  еще Console.Write($"{NaturalNumber(n, m + 1)}, ");
  вернуть м;
}

int n = Подсказка («Введите N:»);
если (n < 1)
{
  Console.WriteLine("Вставьте положительное число!");
  возвращаться;
}
Console.WriteLine(NaturalNumber(n, 1));