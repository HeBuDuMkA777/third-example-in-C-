using System;
using static System.Console;

Clear();
WriteLine("Введите координату Х первой точки: ");
int x1 = int.Parse(ReadLine());
WriteLine("Введите координату Y первой точки: ");
int y1 = int.Parse(ReadLine());
WriteLine("Введите координату Z первой точки: ");
int z1 = int.Parse(ReadLine());
WriteLine("Введите координату Х второй точки: ");
int x2 = int.Parse(ReadLine());
WriteLine("Введите координату Y второй точки: ");
int y2 = int.Parse(ReadLine());
WriteLine("Введите координату Z второй точки: ");
int z2 = int.Parse(ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); // формула из ChatGPT :), я очень предсказуемо назвал переменные, даже менять ничего не пришлось

WriteLine($"{result:f2} ");