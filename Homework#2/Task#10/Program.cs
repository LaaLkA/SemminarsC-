// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

System.Console.WriteLine("Введите трёхзначное число");
string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);

if (Number > 99 && Number < 999)
{
    int secondNumber = Number % 100 / 10;
    System.Console.WriteLine($"Второй цифрой введённого числа {Number} является {secondNumber}");
}
else
{
    System.Console.WriteLine($"Вы ввели некоректное число. Ваше число {Number}");
}