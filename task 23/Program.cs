﻿Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

for(int i = 1; i <= n; i++)
Console.Write($"{i * i * i} ");