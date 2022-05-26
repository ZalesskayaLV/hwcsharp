/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//метод, который инициализирует массив из случайных чисел в промежутке от 100 до 999.
int[] InitArray(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

//метод, который считает количество четных чисел в массиве
int FindEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

// метод, который печатает массив на консоль
void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item}  ");
}



Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());

int[] arr = InitArray(length);

Console.WriteLine("Полученный массив: ");
PrintArray(arr);
int result = FindEvenNum(arr);
Console.WriteLine();

Console.WriteLine($"Количество четных чисел: {result}");