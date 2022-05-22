/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/

void FillArray (int [] collection) // функция создает массив и наполняет его рандомными элементами от 0 до 99
{
    Random randomaiser = new Random(); //определяем переменную, в которую обозначаем класс рандом
    for (int i=0; i<collection.Length; i++)
    {
        collection[i]=randomaiser.Next(0,100);
    }
}



void PrintArray (int [] array) //функция выводит на экран элементы массива
{
    int count = array.Length;
    for(int i=0; i<count;i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}




int [] array = new int [8];
FillArray(array);
PrintArray(array);
