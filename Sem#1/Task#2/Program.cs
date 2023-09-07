// Задача №1. Напишите пограмму, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b  10 -> нет

Console.Clear();

Console.WriteLine("Введите первое число:   ");
string strNumber1 = Console.ReadLine();
Console.WriteLine("Введите второе число:   ");
string strNumber2 = Console.ReadLine();

int number1 = int.Parse(strNumber1);
int number2 = int.Parse(strNumber2);

if (number2 * number2 == number1)
{
    Console.WriteLine("Да, первое число является квадратом второго числа");
}
else 
{
    Console.WriteLine("Нет, первое число не является квадратом второго числа");
}