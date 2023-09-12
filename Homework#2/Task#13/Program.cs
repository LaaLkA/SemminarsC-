// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

System.Console.WriteLine("Введите число");
string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);

void FindThird(int Arg)
{
    int result = 0;

    if (Arg < 100)
    {
        System.Console.WriteLine("Нет третьей цифры");
    }
    else if (Arg < 1000)
    {
        result = Arg % 10;
        System.Console.WriteLine($"Третья цифра числа {Arg} равна {result}");
    }
    else if (Arg < 10000)
    {
        result = Arg % 100 / 10;
        System.Console.WriteLine($"Третья цифра числа {Arg} равна {result}");
    }
    else if (Arg < 100000)
    {
        result = Arg % 1000 / 100;
        System.Console.WriteLine($"Третья цифра числа {Arg} равна {result}");
    }
    else if (Arg < 1000000)
    {
        result = Arg % 10000 / 1000;
        System.Console.WriteLine($"Третья цифра числа {Arg} равна {result}");
    }
    else
    {
        System.Console.WriteLine("Слишком большое число");
    }
}

FindThird(Number);