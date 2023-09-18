// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 91233 -> 5

int GetNumber(string message)
{
    Console.WriteLine($"Enter {message}");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
int NumbersInNumber(int Number)
{
    int count = 0;
    for (; 0 < Number; Number /= 10)
    {
        count++;
    }
    return count;
}
Console.Clear();
int Number = GetNumber("numeber");
int count = NumbersInNumber(Number);
Console.WriteLine($"Numbers in number = {count}");