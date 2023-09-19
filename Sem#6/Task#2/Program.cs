// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать тругольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы других сторон

int take(string message)
{
    System.Console.WriteLine($"Enter {message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void CheckTriangle(int num1, int num2, int num3)
{
    if (num1 > num2 + num3 && num2 > num1 + num3 && num3 > num1 + num2) System.Console.WriteLine("Такой треугольник не существует");
    else System.Console.WriteLine("Такой треугольник не существует");
}

Console.Clear();
int num1 = take("Number1");
int num2 = take("Number1");
int num3 = take("Number1");
CheckTriangle(num1, num2, num3);