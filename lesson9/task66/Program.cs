/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/



int SummRangeNaturalNumber(int m, int n)
{
    int summ = 0;
    if (m == n)
        return m;

    else return summ += n + SummRangeNaturalNumber(m, n - 1);
}


Console.WriteLine("Введите число M");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = int.Parse(Console.ReadLine());


int summ = SummRangeNaturalNumber(numberM, numberN);
Console.WriteLine(summ);