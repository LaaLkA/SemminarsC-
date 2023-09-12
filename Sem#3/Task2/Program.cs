// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

int TakeNumber(string message)
{
    Console.Write($"Введите {message}: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    if(Number < 0) Console.WriteLine("Номер четверти не может быть отрицательным!");
    else if(Number > 4) Console.WriteLine("Существует всего 4 четверти!");
    return Number;
}

void ShowDiap (int Number)
{
    if (Number == 1) Console.WriteLine($"{Number} четверти соответствуют значения: X > 0, y > 0");
    else if(Number == 2) Console.WriteLine($"{Number} четверти соответствуют значения: X < 0, y > 0");
    else if(Number == 3) Console.WriteLine($"{Number} четверти соответствуют значения: X < 0, y < 0");
    else if(Number == 4) Console.WriteLine($"{Number} четверти соответствуют значения: X > 0, y < 0");
}

int Number = TakeNumber("Четверть");
ShowDiap(Number);