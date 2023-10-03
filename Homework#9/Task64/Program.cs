// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int TakeNumber(string message)
{
    System.Console.WriteLine($"Enter {message}");
    if (int.TryParse(Console.ReadLine(), out int Number)) return Number;
    else return TakeNumber(message);
}
void PrintAllNaturalNumbers(int Number)
{
    if (Number > 0)
    {
        System.Console.Write(Number + "\t");
        PrintAllNaturalNumbers(Number - 1);
    }
}

Console.Clear();
PrintAllNaturalNumbers(TakeNumber("Числа N"));