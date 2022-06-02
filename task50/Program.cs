/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

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

//метод, который возвращает значение элемента с заданными индексами
void FindElementValue(int[,] matrix, int rowNumber, int columnNumber)
{
    if (rowNumber < matrix.GetLength(0) && columnNumber < matrix.GetLength(1))
        Console.WriteLine(matrix[rowNumber, columnNumber]);
    else Console.WriteLine("Такой элемент в массиве отсутствует");
}


int firstDemension = GetDemension("Введите количество строк матрицы: ");
int secondDemension = GetDemension("Введите количество столбцов матрицы: ");

int[,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(resultMatrix);


int rowNumber = GetDemension("Введите номер строки искомого элемента: ");
int columnNumber = GetDemension("Введите номер столбца искомого элемента: ");
FindElementValue(resultMatrix, rowNumber, columnNumber);













