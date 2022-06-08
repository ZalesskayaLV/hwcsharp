/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить
 строку с наименьшей суммой элементов.*/

//метод, который находит индекс строки с наименьшей суммой элементов
int GetIndexOfMinRow(int[,] matrix)
{
    int indexOfMinRow = 0;
    int rowSumm = 0;
    int min = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSumm += matrix[i, j];
        }

        if (min > rowSumm)
        {
            min = rowSumm;
            indexOfMinRow = i;

        }

        rowSumm = 0;
    }
    return indexOfMinRow;
}

//метод, который печатает строку массива с наименьшей суммой элементов
void PrintRow(int[,] array)
{
    int minRowIndex = GetIndexOfMinRow(array);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[minRowIndex, j]} ");
    }
}


//метод, который переводит строку в число
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


//метод, который инициализирует массив случайными числами от -10 до 10
int[,] InitMatrix(int rowsNumber, int columnsNumber)
{
    int[,] matrix = new int[rowsNumber, columnsNumber];
    Random rnd = new Random();
    for (int i = 0; i < rowsNumber; i++)
    {
        for (int j = 0; j < columnsNumber; j++)
        {
            matrix[i, j] = rnd.Next(-10, 11);
        }
    }
    return matrix;
}


//метод, который печатает массив на консоль
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}


int rows = GetNumber("Введите количество строк матрицы: ");
int columns = GetNumber("Введите количество столбцов матрицы: ");
Console.WriteLine();

int[,] array = InitMatrix(rows, columns);
PrintArray(array);
Console.WriteLine();

int minRowIndex = GetIndexOfMinRow(array);
Console.WriteLine($"строка с наименьшей суммой элементов: {minRowIndex}");
PrintRow(array);




