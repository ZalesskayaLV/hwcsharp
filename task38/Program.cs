/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/


// метод, который инициализирует массив из случайных вещественных чисел в промежутке от 10 до 99.
double[] InitArray(int length)
{
    double[] arr = new double[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(10, 99);
    }
    return arr;
}



//метод, который находит разность между максимальным и минимальным элементами массива
double GetDiffFromArray(double[] array)
{
    double maxNum = array[0];
    double minNum = array[0];
    

    for (int i = 0; i < array.Length; i++)
    {
    
        if (array[i] > maxNum)
            maxNum = array[i];


       
         if (array[i] < minNum)
                minNum = array[i];
        
        
    }
    double diff = maxNum - minNum;
    return diff;
}

//метод, который считает разность между максимальным и минимальным элементами массива
/*double DiffMaxMin(double max, double min)
{
    double diff = max - min;
    return diff;
}*/


// метод, который печатает массив на консоль
void PrintArray(double[] array)
{
    foreach (double item in array)
        Console.Write($"{item}  ");
}


Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());

double[] array = InitArray(length);
PrintArray(array);
Console.WriteLine();

double resultdiff = GetDiffFromArray(array);
Console.WriteLine($"разность между макс и мин элементами: {resultdiff}");

