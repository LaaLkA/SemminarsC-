// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int take(string message)
{
    Console.WriteLine($"Enter {message}");
    int number = int.Parse(Console.ReadLine());
    return number;
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
void Sort(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int indexMin = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, indexMin] > matrix[i, k]) indexMin = k;
            }
            if (matrix[i, indexMin] == matrix[i, j]) continue;
            temp = matrix[i, j];
            matrix[i, j] = matrix[i, indexMin];
            matrix[i, indexMin] = temp;
        }
    }
}
void Print(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}, ");
        }
        System.Console.WriteLine();
    }
}
// int rows = take("rows");
// int columns = take("columns");
// int minValue = take("minValue");
// int maxValue = take("maxValue");

Console.Clear();
int[,] matrix = GetMatrix(take("rows"),take("columns"),take("minValue"),take("maxValue"));
Print(matrix);
Sort(matrix);
Print(matrix);