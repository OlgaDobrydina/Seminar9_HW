/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите n ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите m ");
int m = int.Parse(Console.ReadLine());
AckermanFunction(n, m);
Console.Write(AckermanFunction(n, m));


int AckermanFunction(int n,int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AckermanFunction(n - 1, 1);
    else return AckermanFunction(n -1, AckermanFunction(n, m - 1));
}
