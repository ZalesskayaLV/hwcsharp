/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9*/

int Akkermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return Akkermann(m - 1, 1);
    else
        return Akkermann((m - 1), Akkermann(m, n - 1));

}

int m = 2;
int n = 3;
int akkValue = Akkermann(m, n);
Console.WriteLine($"m = {m} n = {n} значение = {akkValue}");