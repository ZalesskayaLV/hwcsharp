/*Задача 62: Заполните спирально массив 4 на 4.*/

int[,] SpiralMatrix()
{
    int rowsNumber = 4;
    int columnsNumber = 4;
    int numbers = 1;
    int[,] matrix = new int[rowsNumber, columnsNumber];
    FillAroundMatrix(matrix, numbers);
    return matrix;
}

//метод, который заполняет массив по спирали
void FillAroundMatrix(int[,] matrix, int InitialValue)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[0, j] = InitialValue;
        InitialValue++;
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        matrix[i, matrix.GetLength(1) - 1] = InitialValue;
        InitialValue++;
    }
    for (int j = matrix.GetLength(1) - 2; j >= 0; j--)
    {
        matrix[matrix.GetLength(0) - 1, j] = InitialValue;
        InitialValue++;
    }
    for (int i = matrix.GetLength(0) - 2; i > 0; i--)
    {
        matrix[i, 0] = InitialValue;
        InitialValue++;

    }
    int k = 1;
    int t = 1;

    while (InitialValue < matrix.GetLength(0) * matrix.GetLength(1))
    {
        while (matrix[k, t + 1] == 0)
        {
            matrix[k, t] = InitialValue;
            InitialValue++;
            t++;
        }

        while (matrix[k + 1, t] == 0)
        {
            matrix[k, t] = InitialValue;
            InitialValue++;
            k++;

        }

        while (matrix[k, t - 1] == 0)
        {
            matrix[k, t] = InitialValue;
            InitialValue++;
            t--;

        }

        while (matrix[k - 1, t] == 0)
        {
            matrix[k, t] = InitialValue;
            InitialValue++;
            k--;

        }
    }

    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            if (matrix[x, y] == 0)
                matrix[x, y] = InitialValue;
        }
    }
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



int[,] matrix = SpiralMatrix();
PrintArray(matrix);
