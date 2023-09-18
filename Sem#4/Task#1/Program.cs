// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10

int GetNumber (string message)
{
    Console.WriteLine($"Enter {message}");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
int GetSum (int Number)
{
    int Sum = 0;
    for (int i = 0; i <= Number; i++)
    {
        Sum += i;
    }
    return Sum;
}
void Write (int Number, int Sum)
{
    Console.WriteLine($"{Number} -> {Sum}");
}
int Number = GetNumber("number");
int Sum = GetSum(Number);
Write(Number, Sum);

int num = 10; 
int num2 = num++;//num2 = 10; num = 10 + 1 = 11
Console.WriteLine($"num = {num}, num2 = {num2}");