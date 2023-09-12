// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();

int GetNumber(string message)
{
    Console.WriteLine($"Enter number {message}:  ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Show (int x, int y)
{
    if(x > 0 && y > 0) System.Console.WriteLine("Первая четверть");
    else if(x < 0 && y > 0) System.Console.WriteLine("Вторая четверть");
    else if(x < 0 && y < 0) System.Console.WriteLine("Третья четверть");
    else if(x > 0 && y < 0) System.Console.WriteLine("Четвертая четверть");
    else if(x == 0 || y == 0) System.Console.WriteLine("X ≠ 0 и Y ≠ 0");
}

int NumberX = GetNumber("X");
int NumberY = GetNumber("Y");

Show(NumberX, NumberY);


