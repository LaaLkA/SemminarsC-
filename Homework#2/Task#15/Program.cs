// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

System.Console.WriteLine("Введите цифру, обозначающую день недели в РФ");
string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);

if (Number < 7 && Number > 0)
{
    if (Number > 5)
    {
        System.Console.WriteLine($"{Number} день недели соответствует выходному дню");
    }
    else 
    {
        System.Console.WriteLine($"{Number} день недели соответствует рабочему дню");
    }
}
else 
{
    System.Console.WriteLine($"Цифра {Number} некорректная");
}