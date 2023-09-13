// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// Например:
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
int takeNumber(string message)
{
    Console.WriteLine($"Введите {message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void tableUmn(int number)
{
    for (int i = 0; i <= number; i++)
    {
        int res = number * i;
        Console.WriteLine($"{number} * {i} = {res}"); 
    }
}
int number = takeNumber("число");
tableUmn(number);