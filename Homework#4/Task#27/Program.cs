// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int take()
{
    Console.WriteLine($"Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Sum(int number)
{
    int Summ = 0;
    for (; 0 < number; number /= 10)
    {
        Summ = Summ + number % 10;
    }
    return Summ;
}
System.Console.WriteLine(Sum(take()));