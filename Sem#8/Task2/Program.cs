// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int TakeNumbers(string message)
{
    System.Console.WriteLine($"Enter {message}");
    int number = int.Parse(Console.ReadLine());
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
// int[,] SwapRowsToColumns(int[,] matrix)
// {
//     if (matrix.GetLength(0) == matrix.GetLength(1))
//     {
//         int[,] NewMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 NewMatrix[j, i] = matrix[i, j];
//             }
//         }
//         return NewMatrix;
//     }
//     else 
//     {
//         System.Console.WriteLine("Количество символов в столбце больше символов в строке.");
//         return matrix;
//     }
// }
void SwapRowsToColumns(int[,] matrix) //Данный метод работает только для равновеликой матрицы (4 на 4б 5 на 5 и тд)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        int temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
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

Console.Clear();
int[,] matrix = TakeMatrix(TakeNumbers("rows"), TakeNumbers("columns"));
Print(matrix);
SwapRowsToColumns(matrix);
Print(matrix);

