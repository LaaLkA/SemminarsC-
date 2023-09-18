// Hапишите программу, которая на вход принимает число N и выдаёт произведение от 1 до N.
// 5 -> 120
// 4 -> 24

int GetNumber(string message)
{
    Console.WriteLine($"Enter {message}");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
long UmnNumber(int Number)
{
    long result = 1;
    for (int i = 1; i <= Number; i++)
    {
        result = result * i;
    }
    return result;
}
Console.Clear();
int Number = GetNumber("number");
long res = UmnNumber(Number);
Console.WriteLine($"Произведение чисел от 1 до {Number} = {res}");