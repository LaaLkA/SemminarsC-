// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int TakeNumber(string message)
{
    System.Console.WriteLine($"Enter {message}");
    if (int.TryParse(Console.ReadLine(), out int Number)) return Number;
    return TakeNumber(message);
}
int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

// (int, int) Input()
// {
//     Console.WriteLine("Введите m");
//     int m = int.Parse(Console.ReadLine());
//     Console.WriteLine("Введите n");
// //     int n = int.Parse(Console.ReadLine());
// //     return (m, n);
// // }

// (int m, int n) = Input();

Console.Clear();
Console.WriteLine(AkkermanFunc(TakeNumber("m"), TakeNumber("n")));