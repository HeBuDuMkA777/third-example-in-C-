using System;
using static System.Console;

Clear();
Write("Введите число: ");
int num = int.Parse(ReadLine());
int first = num % 10;
int sec = (num % 100) / 10;
int thir = (num % 1000) / 100;
int four = (num % 10000) / 1000;
int five = num / 10000;
int palind = (first * 10000) + (sec * 1000) + (thir * 100) + (four * 10) + five;

if (palind == num)
{
    WriteLine("Число палиндром!");
}
else
{
    WriteLine("Нет, число не палиндром!");
}