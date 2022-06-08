/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет 
находить произведение двух матриц.*/

//метод, который производит умножение 2х матриц
//для умножения матриц (A)*(B) количество столбцов А должно быть равно количеству строк В
//на выходе матрица размером(строкиА, столбцыВ)
int[,] MatrixCalculator(int[,] matrixA, int[,] matrixB)
{
    int[,] multiplication = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                multiplication[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return multiplication;
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

//метод, который переводит строку в число
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
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


int rows1 = GetNumber("Введите количество строк матрицы1: ");
int columns1 = GetNumber("Введите количество столбцов матрицы1: ");
int rows2 = GetNumber("Введите количество строк матрицы2: ");
int columns2 = GetNumber("Введите количество столбцов матрицы2: ");
Console.WriteLine();

int[,] array = InitMatrix(rows1, columns1);
PrintArray(array);
Console.WriteLine();

int[,] matrix = InitMatrix(rows2, columns2);
PrintArray(matrix);
Console.WriteLine();

if (columns1 != rows2)
    Console.WriteLine($"матрицы не согласованы, произведение невозможно");
else
{
    int[,] multResult = MatrixCalculator(array, matrix);
    PrintArray(multResult);
}