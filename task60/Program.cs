/*Задача 60: Сформируйте трёхмерный массив
 из неповторяющихся двузначных чисел. 
 Напишите программу, которая будет построчно
выводить массив, добавляя индексы каждого элемента.*/

//метод, который инициализирует 3хмерный массив случайными неповторяющимися числами от 10 до 99
int[,,] InitMatrix(int rowsNumber, int columnsNumber, int pagesNumber)
{
    int[,,] matrix = new int[rowsNumber, columnsNumber, pagesNumber];
    Random rnd = new Random();
    for (int i = 0; i < rowsNumber; i++)
    {

        for (int j = 0; j < columnsNumber; j++)
        {
            for (int k = 0; k < pagesNumber; k++)
            {
                bool uniqueNumber = false;
                int number = 0;
                while (!uniqueNumber)
                {
                    number = rnd.Next(10, 100);
                    uniqueNumber = RepeatSearch(matrix, number);

                }
                matrix[i, j, k] = number;

            }
        }
    }
    return matrix;
}

//метод возвращает уникальные значения массива
bool RepeatSearch(int[,,] matrix, int number)
{
    bool isUnique = true;
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == number)
                {
                    isUnique = false;
                }
            }
        }
    }
    return isUnique;
}


//метод, который переводит строку в число
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//метод, который печатает массив на консоль
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($" ({i}, {j}, {k}) {matrix[i, j, k]} ");
            }
        }
        Console.WriteLine();
    }

}


int rows = GetNumber("Введите количество строк матрицы:");
int columns = GetNumber("Введите количество столбцов матрицы:");
int pages = GetNumber("Введите количество листов матрицы:");
Console.WriteLine();

int[,,] matrix = InitMatrix(rows, columns, pages);
PrintMatrix(matrix);