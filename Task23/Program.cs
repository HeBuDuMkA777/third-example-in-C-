using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine());
int counter = 1;

while (counter != number)
{
    Write($"{Math.Pow(counter, 3)}, ");
    counter++;
}

Write(Math.Pow(number, 3));