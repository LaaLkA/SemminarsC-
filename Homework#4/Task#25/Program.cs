// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int take(string message)
{
    Console.WriteLine($"Введите {message} число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void Mnoj(int number1, int number2)
{
    double Number = Math.Pow(number1, number2);
    Console.WriteLine($"{number1}, {number2} -> {Number}");
}
Console.Clear();
Mnoj(take("первое"), take("второе"));