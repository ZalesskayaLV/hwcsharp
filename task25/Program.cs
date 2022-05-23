/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double GetDegree(int number1, int number2) //функция возводит число в степень
{
    double degree = Math.Pow(number1, number2);
    return degree;
}




int GetNaturalNumber(string msg) //функция проверяет что ввели натуральное число
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            if (number > 0)
                return number;
            else
            {
                Console.WriteLine("Вы ввели не натуральное число. Введите число B.");
            }

        }
        else
        {
            Console.WriteLine("Вы ввели не число. Введите число B.");
        }
    }
}




int GetNumber(string msg) //функция проверяет что ввели число
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
            Console.WriteLine("Вы ввели не число. Введите число A.");
        }
    }
}

int numberA = GetNumber("Введите число А: ");
int degreeB = GetNaturalNumber("Введите натуральное число В: ");

double result = GetDegree(numberA, degreeB);
Console.WriteLine($"{numberA}, {degreeB} -> {result}");