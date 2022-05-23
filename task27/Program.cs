/* 27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12
*/

int GetSummNumberDigit(int num) //метод получает сумму цифр числа
{
    string number = Convert.ToString(num);
    int summ = 0;
    for (int i = 0; i < number.Length; i++)
    {
        summ += number[i];
    }
    return summ;
}



int GetNumber(string msg) //метод проверяет что ввели число
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Введите число .");
        }
    }
}



int number = GetNumber("Введите число: ");

int result = GetSummNumberDigit(number);

Console.WriteLine($"{number} -> {result}");