﻿/*Задайте значение N. Напишите программу, которая выведет все натуральные
 числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите натуральное число ");
int number = int.Parse(Console.ReadLine());
NaturalNambers(number);

void NaturalNambers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNambers(num - 1);    
}
