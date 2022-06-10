/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.*/

//метод, который переводит строку в число
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


//метод, который инициализирует массив случайными числами от 1 до 10
int[,] InitMatrix(int rowsNumber, int columnsNumber)
{
    int[,] matrix = new int[rowsNumber, columnsNumber];
    Random rnd = new Random();
    for (int i = 0; i < rowsNumber; i++)
    {
        for (int j = 0; j < columnsNumber; j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

//метод сортирует каждую строку массива по убыванию и записывает в новый массив
int[,] SortDescending(int[,] matrix)
{
    int[,] array = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] lineArray = new int[matrix.GetLength(1)];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            lineArray[j] = matrix[i, j];
        }
        lineArray = Sort(lineArray);

        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            array[i, j] = lineArray[j];
        }
    }
    return array;
}

//метод, который сортирует строку по убыванию
int[] Sort(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

        }
    }
    return array;
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

int[,] array = InitMatrix(rows, columns);
PrintArray(array);
Console.WriteLine();

int[,] sortArray = SortDescending(array);
PrintArray(sortArray);



