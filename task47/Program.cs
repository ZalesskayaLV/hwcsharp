/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


//метод, который переводит строку в число
int GetDemension(string message)
{
    Console.Write(message);
    int demension = int.Parse(Console.ReadLine());
    return demension;
}

//метод, который инициализирует массив вещественных чисел от -10 до 10
double[,] InitMatrix(int firstDemension, int secondDemension)
{
    double[,] matrix = new double[firstDemension, secondDemension];
    Random rnd = new Random();

    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            matrix[i, j] = Convert.ToDouble(rnd.Next(-10, 100)/10.0);
    }
    return matrix;
}


//метод, который печатает массив на консоль
void PrintMatrix(double[,] matrix)
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

double[,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(resultMatrix);



