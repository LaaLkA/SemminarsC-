// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

// const int num2 = 5; // ввод константы, которая никогда не будет изменяться

int TakeNumber(string message)
{
    Console.Write($"Введите {message}: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    // if(Number < 0) Console.WriteLine("Номер четверти не может быть отрицательным!");
    // else if(Number > 4) Console.WriteLine("Существует всего 4 четверти!");
    return Number;
}

// void ShowDiap (int Number)
// {
//     if (Number == 1) Console.WriteLine($"{Number} четверти соответствуют значения: X > 0, y > 0");
//     else if(Number == 2) Console.WriteLine($"{Number} четверти соответствуют значения: X < 0, y > 0");
//     else if(Number == 3) Console.WriteLine($"{Number} четверти соответствуют значения: X < 0, y < 0");
//     else if(Number == 4) Console.WriteLine($"{Number} четверти соответствуют значения: X > 0, y < 0");
// }

// int Number = TakeNumber("Четверть");
// ShowDiap(Number);

int quarter = TakeNumber("quarter");
// switch - оператор ветвления
switch (quarter)
{
    case 1: // наше число сравнили с еденицей
    {
        Console.WriteLine("X > 0, y > 0");
        break;
    }
    case 2: // наше число сравнили с двойкой
    {
        Console.WriteLine("X < 0, y > 0");
        break;
    }
    case 3: // наше число сравнили с тройкой
    {
        Console.WriteLine("X < 0, y < 0");
        break;
    }
    case 4: // наше число сравнили с четверкой
    {
        Console.WriteLine("X > 0, y < 0");
        break;
    }
    default: // срабатывает, если не сработали предидущие условия
    {
        Console.WriteLine("Введена неправильная четверть");
        break;
    }
}