﻿Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
double x = (Math.Pow(a, 3) + Math.Pow(b, 3)) / 2;
double y = Math.Sqrt(Math.Abs(a) * Math.Abs(b));
Console.WriteLine($"средние арифметическое: {x} , Площадь геометрическое: {y}");
