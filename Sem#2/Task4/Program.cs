// Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23

Console.Clear();

System.Console.WriteLine("Введите число");
string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);

int del1 = 7;
int del2 = 23;

if (Number % del1 == 0 && Number % del2 == 0)
{
    System.Console.WriteLine($"Число {Number} кратно {del1} и {del2}");
}
else
{
    System.Console.WriteLine($"Число {Number} не кратно {del1} и {del2}");
}
