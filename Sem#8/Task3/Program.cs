// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int TakeNumbers(string message)
{
    System.Console.WriteLine($"Enter {message}");
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
int[,] TakeMatrix(int rows, int columns)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 100);
        }
    }
    return matrix;
}
void SearchMin(int[,] matrix, out int imin, out int jmin)
{
    imin = 0;
    jmin = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                imin = i;
                jmin = j;
            }
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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] DeleteRowCol(int[,] matrix, int row, int col)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    int inew = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == row) continue;

        int jnew = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == col) continue;
            newMatrix[inew, jnew] = matrix[i, j];
            jnew++;
        }
        inew++;
    }
    return newMatrix;
}

Console.Clear();
int imin;
int jmin;
int[,] matrix = TakeMatrix(TakeNumbers("rows"), TakeNumbers("columns"));
Print(matrix);
SearchMin(matrix, out imin, out jmin);
System.Console.WriteLine($"{imin},  {jmin}");
int[,] result = DeleteRowCol(matrix, imin, jmin);
Print(result);