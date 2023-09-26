// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int GetNumber(string message)
{
                System.Console.WriteLine($"Enter {message}");
                int Number = int.Parse(Console.ReadLine());
                return Number;
}
int[,] TakeMatrix(int rows, int columns)
{
                int[,] matrix = new int[rows, columns];
                Random rand = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                               matrix[i,j] = rand.Next(0,10); 
                                }
                }
                return matrix;
}
int[,] DoWork(int[,] matrix)
{
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                                if ((i % 2 == 0) && (j % 2 == 0)) matrix[i, j] *= matrix[i, j];
                                                else continue;
                                }
                }
                return matrix;
}
void Print(int[,] matrix)
{
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                                Console.Write($"{matrix[i, j]} ");
                                }
                                Console.WriteLine();
                }
}

Console.Clear();
int rows = GetNumber("Rows");
int columns = GetNumber("Columns");
int[,] matrix = TakeMatrix(rows, columns);
Print(matrix);
System.Console.WriteLine("");
DoWork(matrix);
Print(matrix);