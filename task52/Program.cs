/*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


//метод, который переводит строку в число
int GetDemension(string message)
{
    Console.Write(message);
    int demension = int.Parse(Console.ReadLine());
    return demension;
}

//метод, который инициализирует массив целых чисел от 1 до 9
int[,] InitMatrix(int firstDemension, int secondDemension)
{
    int[,] matrix = new int[firstDemension, secondDemension];
    Random rnd = new Random();

    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            matrix[i, j] = rnd.Next(1, 10);
    }
    return matrix;
}

//метод, который считает среднее арифметическое каждого столбца
string GetAverageColumn(int[,] matrix)
{
    double summ = 0;
    string result = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[j, i];
        }
        summ = Math.Round(summ / matrix.GetLength(0), 1);
        result += summ + "; ";
        summ = 0;
    }
    return result;
}

//метод, который печатает массив на консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }

}

int firstDemension = GetDemension("Введите количество строк матрицы: ");
int secondDemension = GetDemension("Введите количество столбцов матрицы: ");

int[,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(resultMatrix);

string result = GetAverageColumn(resultMatrix);
Console.WriteLine(result);





