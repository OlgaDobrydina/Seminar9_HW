/*Задайте значения M и N. Напишите программу, которая найдёт
 сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите натуральное число ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число ");
int m = int.Parse(Console.ReadLine());
NaturalnessTest(n,m);
SummaOfNaturalNamber(n);
Console.Write(SummaOfNaturalNamber(n));

void NaturalnessTest(int n, int m)
{
    if ( n < 0 || m < 0) Console.Write("Число не является натуральным");       
}

int SummaOfNaturalNamber(int n)
{
    if (n==m) return n;
    else return n + SummaOfNaturalNamber(n+1);
}

