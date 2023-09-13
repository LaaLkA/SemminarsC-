// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();

int takeNumber(string message)
{
    Console.WriteLine($"Enter {message}");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

void Draw(int x1, int y1, int x2, int y2)
{
    double lengthXY = Math.Sqrt(Math.Pow(Math.Pow(x1 - x2, 2), 2) + Math.Pow(Math.Pow(y1 - y2, 2), 2));
    Console.Write($"расстояние между точками равно {lengthXY}");
}

int x1 = takeNumber("x1");
int y1 = takeNumber("y1");
int x2 = takeNumber("x2");
int y2 = takeNumber("y2");
Draw(x1, y1, x2, y2);
