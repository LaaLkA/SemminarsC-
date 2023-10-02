// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int takeNumbers(string message)
{
    System.Console.WriteLine($"Enter {message}");
    int Number = int.Parse(Console.ReadLine());
    return Number;
}
int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return matrix;
}
int NaimSumToRows(int[,] matrix)
{
    int[] Sum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum[i] += matrix[i, j];
        }
        System.Console.Write($"Cумма {i + 1} строки = {Sum[i]}, ");
    }
    System.Console.WriteLine();
    int min = Sum[0];
    for (int k = 1; k < Sum.Length; k++)
    {
        if (Sum[k] < min) min = Sum[k];
    }
    return min;
}
void Print(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}, ");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
int[,] matrix = GetMatrix(takeNumbers("rows"), takeNumbers("columns"), takeNumbers("minValue"), takeNumbers("maxValue"));
Print(matrix);
System.Console.WriteLine($"Минимальная сумма по строкам равна {NaimSumToRows(matrix)}");