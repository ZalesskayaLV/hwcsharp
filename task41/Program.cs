//Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.



//метод считает количество введенных положительных чисел
int GetCountPositivelength(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
            count++;
    }
    return count;
}

//метод, который формирует массив из введенных с клавиатуры чисел
int[] CreateArray(int length, string[] list)
{
    int[] arr = new int[length];

    for (int i = 0; i < length; i++)
    {
        arr[i] = int.Parse(list[i].ToString());
    }
    return arr;
}

//метод переводит строку в число
int GetNumber(string value)
{
    Console.WriteLine(value);
    int number = int.Parse(Console.ReadLine());
    return number;
}


Console.WriteLine("Введите несколько чисел через пробел: ");
string length = Console.ReadLine();
string[] list = length.Split(" ");


int lengthArray = GetNumber("Введите количество введенных чисел: ");
int[] arraylengthString = CreateArray(lengthArray, list);

int result = GetCountPositivelength(arraylengthString);
Console.WriteLine($"Количество положительных чисел равно: {result}");