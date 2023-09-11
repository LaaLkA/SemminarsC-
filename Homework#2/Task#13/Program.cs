// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

System.Console.WriteLine("Введите число");
string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);
int countNumbers = 1000;
int k = 10;

if (Number < 100)
{
    System.Console.WriteLine($"Третьей цифры у числа {Number} нет");
}
else
{
    while (countNumbers > Number)
    {

        if (Number < countNumbers)
        {
            int thirdNumber = Number % k;
            System.Console.WriteLine($"Третьей цифрой числа {Number} является {thirdNumber}");
            Number = Number * 10;
        }
        else
        {
            k = k * 10;
            countNumbers = countNumbers * 10;
        }
    }

}