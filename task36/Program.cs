/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


//метод, который инициализирует массив из случайных чисел в промежутке от -10 до 49.
int[] InitArray(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-10, 50);
    }
    return arr;
}

//метод, который считает сумму элементов, стоящих на нечетных позициях
int SummNumberOnOddPosition(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            summ += array[i];
    }
    return summ;
}

// метод, который печатает массив на консоль
void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item}  ");
}




Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = InitArray(length);
PrintArray(array);
Console.WriteLine();

int result = SummNumberOnOddPosition(array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях: {result}");