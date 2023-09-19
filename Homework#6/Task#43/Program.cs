// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int take(string message)
{
    Console.WriteLine($"Enter {message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.Clear();
double b1 = take("b1");
double k1 = take("k1");

double b2 = take("b2");
double k2 = take("k2");

double x = (double)(b2 - b1) / (double)(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения - X:{x}, Y:{y}");