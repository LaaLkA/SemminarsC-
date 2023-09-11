// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();

System.Console.WriteLine("Введите трёхзначное число");
string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);

if (Number > 99 && Number < 1000)
{
    int secondNumber = Number %100 / 10;
    System.Console.WriteLine($"вторая цифра заданного числа = {secondNumber}");
}
else
{
    System.Console.WriteLine("Вы ввели некорректное число!");
}