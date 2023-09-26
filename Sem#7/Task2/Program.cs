// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int GetNumber(string message)
{
                Console.WriteLine($"Enter {message}");
                int Number = int.Parse(Console.ReadLine());
                return Number;
}
int[,] GetMatrix(int m, int n)
{
                int[,] matrix = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                                for (int j = 0; j < n; j++)
                                {
                                                matrix[i, j] = i + j;
                                }
                }
                return matrix;
}
void Print(int[,] matrix)
{
                for (int i = 0; i < matrix.GetLength(0); i++)//проходим по столбцам
                {
                                for (int j = 0; j < matrix.GetLength(1); j++)//проходим по строке
                                {
                                                Console.Write($"{matrix[i, j]} ");
                                }
                                Console.WriteLine();
                }
}

Console.Clear();
int m = GetNumber("m");
int n = GetNumber("n");
int[,] matrix = GetMatrix(m, n);
Print(matrix);


