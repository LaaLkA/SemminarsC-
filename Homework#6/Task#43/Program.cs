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
int b1 = take("b1");
int k1 = take("k1");

int b2 = take("b2");
int k2 = take("k2");

int x = (b2 - b1) / (k1 - k2);
int y = k1 * x + b1;

Console.WriteLine($"Точка пересечения - X:{x}, Y:{y}");