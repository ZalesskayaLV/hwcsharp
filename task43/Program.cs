/*Задача 43. Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
y=k1*x+b1
y=k2*x+b2
Значения b1, k1, b2 и k2 задаются пользователем.

b1=2, k1=5, b2=4, k2=9 -> (-0.5; 5,5)
*/

//метод находит точку пересечения прямых
(double, double) GetPointOfIntersection(double b1, double k1, double b2, double k2)

{
    double x = (b2-b1)/(k1-k2);
    double y = k2 * x + b2;
    return (x, y);
}


//метод считывает введенный текст из строки и возвращает число
int GetNumber(string value)
{
    while (true)
    {
        Console.WriteLine(value);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}


double b1 = GetNumber("Введите b1: ");
double k1 = GetNumber("Введите k1: ");
double b2 = GetNumber("Введите b2: ");
double k2 = GetNumber("Введите k2: ");

//проверка на параллельность прямых
if (k1 != k2)
{
    (double, double) result = GetPointOfIntersection(b1, k1, b2, k2);
    Console.WriteLine($"точка пересечения прямых имеет координаты: {result} ");
}
else Console.WriteLine("Прямые параллельны");

