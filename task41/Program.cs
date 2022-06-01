//Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.



//метод считает количество введенных положительных чисел
int GetCountPositive(string[] array)
{
    int countOfPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (int.TryParse(array[i], out int number) && number > 0)
            countOfPositive++;
    }
    return countOfPositive;
}


Console.WriteLine("Введите несколько чисел через пробел: ");
string numbers = Console.ReadLine();
string[] list = numbers.Split(" ");


int result = GetCountPositive(list);
Console.WriteLine($"Количество положительных чисел равно: {result}");