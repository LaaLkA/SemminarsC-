// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int TakeNumber(string message)
{
    System.Console.WriteLine($"Enter {message}");
    if (int.TryParse(Console.ReadLine(), out int Number)) return Number;
    return TakeNumber(message);
}
int SumNaturalElements(int Number1, int Number2, int Sum)
{
    if (Number1 - 1 == Number2) return Sum;
    else
    {
        Sum = Sum + Number2;
        return SumNaturalElements(Number1, Number2 - 1, Sum);
    }
}

Console.Clear();
int Sum = 0;
System.Console.WriteLine(SumNaturalElements(TakeNumber("M"), TakeNumber("N"), Sum));