// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int SetNumber(string message)
{
Console.Write($"Enter number {message}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}
// Console.Write("Enter number : ");

// string str = Console.ReadLine();
// string[] strNums = str.Split(" ",StringSplitOptions.RemoveEmptyEntries);
// int[] ints = new int[strNums.Length];

// for (int i = 0; i < strNums.Length; i++)
// {
// ints[i] = Convert.ToInt32(strNums[i]);
// }
// System.Console.WriteLine(string.Join(", ", ints));

int rows = SetNumber("rows");
int columns = SetNumber("columns");

int[,] array = GetMatrix(rows, columns);
PrintMatrix(array);

int[,] GetMatrix(int rows, int columns, int minValue = 10, int maxValue = 99)
{
int[,] matrix = new int[rows, columns];
Random rand = new Random();

for (int i = 0; i < rows; i++)
{
for (int l = 0; l < columns; l++)
{
matrix[i, l] = rand.Next(minValue, maxValue + 1);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int l = 0; l < matrix.GetLength(1); l++)
{
Console.Write($"{matrix[i, l]} ");
}
Console.WriteLine();
}
}