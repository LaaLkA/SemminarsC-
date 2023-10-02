// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] Proizv(int[,] matrix1, int[,] matrix2)
{
    int[,] Rezultmatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Rezultmatrix[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return Rezultmatrix;
}
void Print(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
int[,] matrix1 = GetMatrix(takeNumbers("rows matrix 1"), takeNumbers("columns matrix 1"), takeNumbers("minValue matrix 1"), takeNumbers("maxValue matrix 1"));
int[,] matrix2 = GetMatrix(takeNumbers("rows matrix 2"), takeNumbers("columns matrix 2"), takeNumbers("minValue matrix 2"), takeNumbers("maxValue matrix 2"));
System.Console.WriteLine();
System.Console.WriteLine("Матрица 1");
Print(matrix1);
System.Console.WriteLine();
System.Console.WriteLine("Матрица 2");
Print(matrix2);
if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1))
{
    System.Console.WriteLine();
    System.Console.WriteLine("Произведение 1 и 2 матриц");
    Print(Proizv(matrix1, matrix2));
}
else System.Console.WriteLine("Количество строк и столбцов у матриц не одинаковое!");